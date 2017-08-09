using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Sockets.Exceptions
{
    /// <summary>
    /// thrown when no remote connection has been established
    /// prior to sending data to that client. 
    /// </summary>
    public class NoRemoteClientConnectedException : Exception
    {
        public NoRemoteClientConnectedException()
        {
        }

        public NoRemoteClientConnectedException(string message)
            : base(message)
        {
        }

        public NoRemoteClientConnectedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
