using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class MouldNumberRequestMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.SampleRequest; }
            set { } 
        }
    }
}
