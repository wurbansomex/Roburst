using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrChannelStatusRequest:IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.ChannelStatusRequest; }
            set { }
        }

        public byte SequenceNumber { get; set; }
        public byte CommandCode { get; set; }
    }
}
