using log4net;
using Somex.Roburst.Integration.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Somex.Roburst.Integration.Sockets
{
    /// <summary>
    /// Handles sending receiving of data over a Tcp connection
    /// </summary>
    public class Client
    {

        private TcpClient _tcpClient;
        private NetworkStream _ns; 
        private DateTime _connectionDate;
        private double _receiveDataTimeout;
        private Thread _readDataThread;
        private bool _keepReadThreadAlive;
        private object _readLock = new object();
        static ILog _log = LogManager.GetLogger(typeof(Client));
        private bool _hexCom = false;


        public delegate void DataReceivedHandler(byte[] data, DateTime receivedAt);
        public event DataReceivedHandler DataRecevied;


        public Client(TcpClient tcpClient, double receiveTimeoutInMS)
        {
            try
            {
                _tcpClient = tcpClient;
                _tcpClient.NoDelay = true;
                _tcpClient.Client.NoDelay = true;
                _ns = _tcpClient.GetStream();
                _ns.ReadTimeout = 500;
                _connectionDate = DateTime.Now;
                _receiveDataTimeout = receiveTimeoutInMS;
                _keepReadThreadAlive = true;
                _readDataThread = new Thread(new ThreadStart(ReadDataInBackground));
                _readDataThread.Start();
            }
            catch (Exception ex)
            {
                _log.Error("Error constructing Client object, " + ex.ToString());
            }
        }

        public Client(TcpClient tcpClient, double receiveTimeoutInMS, bool hexCom) : this(tcpClient, receiveTimeoutInMS) 
        {
            _hexCom = hexCom;
        }


        /// <summary>
        /// Sends data to connect client, and optionally waits for response from
        /// the client
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="waitForResponseData"></param>
        /// <returns></returns>
        public T Send<T>(string data, bool waitForResponseData = false)
        {
            _log.Debug("Transmitting String to Client: " + data);
            return Send<T>(Encoding.ASCII.GetBytes(data), waitForResponseData);
        }

        public T Send<T>(byte[] data, bool waitForResponseData = false)
        {

            // this client is running a background thread, waiting for 
            // data from iAFIS. 
            // we need to get grab the lock to prevent both threads reading
            // at the same time.
            T returnData = default(T);
            Type returnType = typeof(T);

            if (_tcpClient == null)
                throw new ApplicationException(string.Format("Error {0}: Cannot send data because there is no active client", AlarmCode.NoActiveClient.PadLeftWithZeros()));

            lock (_readLock)
            {

                byte[] dataBytes = data;
                _log.Debug("Transmitting Data to Client: " + string.Join(",", dataBytes));
                _ns.Write(dataBytes, 0, dataBytes.Length);
                _log.Debug("Transmission Complete");
                if (waitForResponseData)
                {
                    byte[] reponseData = RetrieveResponseData();

                    // convert the response data to the desired type T
                    try
                    {
                        if( returnType == typeof(byte[]))
                        {
                            returnData = (T)Convert.ChangeType(reponseData, typeof(T));
                        }
                        else
                        {
                        string value = Encoding.ASCII.GetString(reponseData, 0, reponseData.Count());
                        returnData = (T)Convert.ChangeType(value, typeof(T));
                        }
                    }
                    catch (InvalidCastException)
                    {
                        throw new ApplicationException(string.Format("Unable to cast byte data to {0}", typeof(T)));
                    }
                }
            }// end lock

            return returnData;
        }

        public void CloseConnection()
        {
            try
            {
                if (this._tcpClient != null)
                {
                    _keepReadThreadAlive = false;
                    _readDataThread.Join();
                    this._ns.Dispose();
                    this._tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                _log.Error(string.Format("Error closing tcp client connection, {0}", ex.Message));
            }
        }

        #region Private Methods

        /// <summary>
        /// Attempts to Read data from client, looping around until thread is stopped.
        /// </summary>
        private void ReadDataInBackground()
        {

            try
            {  
                while (_keepReadThreadAlive)
                {
                    bool isEndOfData = false;
                    List<byte> clientData = new List<byte>(); 

                    do
                    {
                        lock (_readLock)
                        {
                            List<byte> dataReceived = null;
                            isEndOfData = ReadBytes(out dataReceived);
                            clientData.AddRange(dataReceived);

                            if (isEndOfData)
                            {
                                // notify any interested clients
                                if (this.DataRecevied != null)
                                {
                                    this.DataRecevied.BeginInvoke(clientData.ToArray<byte>(), DateTime.Now, null, null); // fire and forget
                                }
                            }
                        }

                        Thread.Sleep(100);
                    }
                    while ((isEndOfData == false) & (_keepReadThreadAlive));
                }
            }
            catch (InvalidOperationException ioe)
            {
                // socket on client side probably closed
                _log.Error(string.Format("Error {0}: {1}" , AlarmCode.ListenForIncomingDataError.PadLeftWithZeros(), ioe.ToString()));
            }
            catch (Exception ex)
            {
                // general error
                _log.Error(string.Format("Error {0}: {1}", AlarmCode.ListenForIncomingDataError.PadLeftWithZeros(), ex.ToString()));
            }
        }


        /// <summary>
        /// Attempts to read from the client, return the data received and whether the
        /// end of data terminator was received. 
        /// </summary>
        /// <param name="dataReceived"></param>
        /// <returns></returns>
        private bool ReadBytes(out List<byte> dataReceived)
        {
            bool isEndOfData = false;
            dataReceived = new List<byte>();

            try
            {
                byte[] buffer = new byte[2024];
                int bytesRead = _ns.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    _log.Debug(string.Format("Data  received (string): '{0}'", data));
                    _log.Debug(string.Format("Data received (bytes): '{0}'", string.Join(",", buffer.Take(bytesRead))));

                    dataReceived = buffer.Take(bytesRead).ToList<byte>();

                    // have we reached the end of the data transmission i.e check for CRLF
                    if (!_hexCom)
                    {
                        byte[] endCharacter = dataReceived.Skip(dataReceived.Count - 2).Take(2).ToArray();
                        isEndOfData = (endCharacter.SequenceEqual(Encoding.ASCII.GetBytes(Environment.NewLine)));
                    }
                    else // check for 0x83
                    {
                        if (dataReceived[dataReceived.Count - 1] == 0x83) // stop byte 1000'0011
                            isEndOfData = true;
                        else
                            isEndOfData = false;
                    }

                    if (isEndOfData)
                    {
                        byte[] allData = dataReceived.ToArray<byte>();

                        _log.Debug("Terminating chars received at: " + DateTime.Now);
                        _log.Debug("Complete Data Received is (string): " + Encoding.ASCII.GetString(allData));
                        _log.Debug("Complete Data Received is (bytes): " + string.Join(",", allData));
                    }
                }
            }
            catch (IOException)
            {
                // ignore as we'll be getting continuous read time outs when there is no data to read
            }
            catch (Exception ex)
            {
                _log.Error("Error in read from stream loop " + ex.ToString());
            }

            return isEndOfData;

        }


        /// <summary>
        /// Retreieve response data from the client. This is called after
        /// data is sent to client.
        /// </summary>
        /// <param name="ns"></param>
        private byte[] RetrieveResponseData()
        {
            DateTime startTime = DateTime.Now;
            bool isFullResponseReceived = false;
            List<byte> responseData = new List<byte>();

            do
            {
                // keep reading data until we receive all bytes or timeout
                List<byte> dataReceived = null;
                isFullResponseReceived = ReadBytes(out dataReceived);
                responseData.AddRange(dataReceived);

                Thread.Sleep(100);
            }
            while ((isFullResponseReceived == false) & (!IsWaitTimeExceeded(startTime)));

            // check if we timed out
            if (!isFullResponseReceived & !_hexCom)
            {
                string errorMsg = string.Format("Error {0}: Read timed out.", AlarmCode.ReceieveDataTimeout.PadLeftWithZeros());
                _log.Error(errorMsg);
                throw new RemoteReadDataTimeoutException(errorMsg);
            }

            if (!isFullResponseReceived & _hexCom)
            {
                return new byte[] {0x82,0x03,0x83};
            }

            return responseData.ToArray<byte>();
        }

        /// <summary>
        /// We need to wait for the IVC Camera to send an EOF delimiter. We can't wait 
        /// forever so this function checks if we've been waiting for 3 seconds
        /// </summary>
        /// <param name="startTime"></param>
        /// <returns></returns>
        private bool IsWaitTimeExceeded(DateTime startTime)
        {
            double timeDifferenceInMilliseconds = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            return timeDifferenceInMilliseconds > _receiveDataTimeout;
        }


        /// <summary>
        /// Returns an Id for the client connection based on date client was connected
        /// </summary>
        /// <returns></returns>
        private string _GetClientID()
        {
            return _connectionDate.ToString("hhMMss");
        }


        #endregion












    }

}
