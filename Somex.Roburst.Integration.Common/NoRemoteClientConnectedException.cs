using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class NoRemoteClientConnectedException : Exception
    {

        public NoRemoteClientConnectedException() { } 

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
