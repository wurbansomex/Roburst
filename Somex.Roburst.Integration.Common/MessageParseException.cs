using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class MessageParseException : Exception
    {

        public MessageParseException() { }

        public MessageParseException(string message)
            : base(message)
        {

        }

        public MessageParseException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
