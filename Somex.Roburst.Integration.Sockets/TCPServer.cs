using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.IO;
using log4net;


namespace Somex.Roburst.Integration.Sockets
{
    /// <summary>
    /// Tcp server, listening for connections and raising an event when a new connect is 
    /// created. 
    /// </summary>
    public class TcpServer
    {
        static ILog _log = LogManager.GetLogger(typeof(TcpServer));

        #region Private Members
        private TcpListener _listener;
        private IPAddress _address;
        private int _port;
        private bool _listening;
        private object _syncRoot = new object();

        #endregion

        public delegate  void NewClientConnectedHandler(TcpClient client, DateTime connectedAt);
        public event NewClientConnectedHandler NewClientConnected;

        public TcpServer(IPAddress address, int port)
        {
            _port = port;
            _address = address;
        }

        #region Properties

        public IPAddress Address
        {
            get { return _address; }
        }

        public int Port
        {
            get { return _port; }
        }

        public bool Listening
        {
            get { return _listening; }
        }
        #endregion

        #region Public Methods

        public void Listen()
        {
            try
            {
                lock (_syncRoot)
                {
                    _listener = new TcpListener(_address, _port);

                    // fire up the server
                    _listener.Start();

                    _log.Info("Waiting for client connections...");

                    // set listening bit
                    _listening = true;
                }

                // Enter the listening loop.
                do
                {
                    _log.Debug("Waiting for Client to Connect.....");
                    TcpClient newClient = _listener.AcceptTcpClient();
                    _log.Debug("Connected to new client");

                    // raise event
                    if (this.NewClientConnected != null)
                    {
                        this.NewClientConnected(newClient, DateTime.Now);
                    }

                    //// Queue a request to take care of the client
                    //ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessClient), newClient);
                }
                while (_listening);
            }
            catch (SocketException se)
            {
                _log.Error("SocketException: " + se.ToString());
            }
            finally
            {
                // shut it down
                StopListening();
            }
        }

        public void StopListening()
        {
            if (_listening)
            {
                lock (_syncRoot)
                {
                    // set listening bit
                    _listening = false;
                    // shut it down
                    _listener.Stop();
                }
            }
        }
        #endregion

        #region Private Methods


        #endregion

    }
}
