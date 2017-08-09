using log4net;
using Somex.Roburst.Integration.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Somex.Roburst.Integration.Sockets
{
    /// <summary>
    /// Manages TCPCLient connection, subscribing to new connections and providing an interface for exchange of data over
    /// these TcpClient connections
    /// </summary>
    public class CommunicationsManager
    {
        static ILog _log = LogManager.GetLogger(typeof(CommunicationsManager));

        

        private Client _currentClient;
        private object _syncLock = new object();
        private TcpServer _tcpServer;
        private int _receiveDataTimeout;
        private TypeOfCommunication _comType;

        public delegate void MessageReceivedHandler(IMessage message);
        public delegate void MessageProcessingErrorHandler();
        public event MessageReceivedHandler MessageReceived;
        public event MessageProcessingErrorHandler MessageProcessingError;


        public CommunicationsManager(string ipAddress, int portNumber, int receiveDataTimeout, TypeOfCommunication comType = TypeOfCommunication.TCP)
        {
            _receiveDataTimeout = receiveDataTimeout;
            _tcpServer = new TcpServer(IPAddress.Parse(ipAddress), portNumber);
            _tcpServer.NewClientConnected += _OnNewClientConnected;
            _comType = comType;
        }


        #region Public Methods

        /// <summary>
        /// Start listenening for incoming tcp connections
        /// </summary>
        public void Start()
        {
            if(_tcpServer != null)
            {
                if (_currentClient != null)
                    _currentClient.CloseConnection();

                _tcpServer.StopListening();
                _tcpServer.Listen();
            }
        }

        /// <summary>
        /// Stops tcp server, preventing incoming requests from being
        /// fullfilled.
        /// </summary>
        public void Stop()
        {
            if (_tcpServer != null)
            {
                _tcpServer.StopListening();
            }
        }

        public string SendData(string data, bool waitForResponse = false)
        {
            string response = string.Empty;

            if (_currentClient != null)
                response = _currentClient.Send<string>(data, waitForResponse);
            else
            {
                _log.Error("Current client is null. Aborting sending of data");
                throw new NoRemoteClientConnectedException("No remote client connected, aborting send operation");
            }

            return response;
        }

        public byte[] SendData(byte[] data, bool waitForResponse = false)
        {

            if (_currentClient != null)
                return _currentClient.Send<byte[]>(data, waitForResponse);
            else
            {
                _log.Error("Current client is null. Aborting sending of data");
                throw new NoRemoteClientConnectedException("No remote client connected, aborting send operation");
            }

        }

        #endregion


        #region Event Handlers

        private void _OnDataReceived(byte[] data, DateTime receivedAt)
        {
            try
            {

                _log.Debug("Handling Data..");

                string dataReceived = Encoding.ASCII.GetString(data);

                IMessage newMessage;

                if (_comType == TypeOfCommunication.TCP)
                {
                    newMessage = iAFISXmlMessageParser.CreateMessage(dataReceived);
                }
                else
                {
                    newMessage = AgrMessageParser.CreateMessage(data);
                }

                // raise event back up to the calling HMI client.
                if (MessageReceived != null)
                {
                    _log.Debug("Calling Message received handler");
                    MessageReceived.BeginInvoke(newMessage, null, null); // fire and forget in new thread to free up this handler
                }

            }
            catch (Exception ex)
            {
                // handle unknown data format
                _log.Error("Could not create message, " + ex.ToString());

                // raise an alarm
                _RaiseError();
            }

        }

        private void _RaiseError()
        {
            if (this.MessageProcessingError != null)
                this.MessageProcessingError.BeginInvoke(null, null);
        }

        private void _OnNewClientConnected(TcpClient newClient, DateTime connectionTime)
        {
            // update the client connection. Close the existing one first. 
            if (this._currentClient != null)
            {
                this._currentClient.DataRecevied -= _OnDataReceived;
                this._currentClient.CloseConnection();
            }

            bool AGRCommType = false;
            if(_comType == TypeOfCommunication.SerialOverTCP)
                AGRCommType = true;
            else
                AGRCommType = false;
            this._currentClient = new Client(newClient,  _receiveDataTimeout, AGRCommType);
            this._currentClient.DataRecevied += _OnDataReceived;
        }

        #endregion 



    }
}
