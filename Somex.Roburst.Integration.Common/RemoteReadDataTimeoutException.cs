using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class RemoteReadDataTimeoutException : Exception
    {

        public RemoteReadDataTimeoutException() { } 

        public RemoteReadDataTimeoutException(string message)
            : base(message)
        {

        }

        public RemoteReadDataTimeoutException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
