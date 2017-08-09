using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrAckMessage:IMessage
    {
        public MessageType MessageType
        {
            get
            {
                return Common.MessageType.AckMessage;
            }
            set { }
        }

        public AgrAckMessage() { }

        public AgrAckMessage ( byte requestSequence, byte requestCommand){
            RequestedSequenceNumber = requestSequence;
            RequestedCommandCode = requestCommand;
        }

        public byte SequenceNumber { get; set; }
        public byte RequestedSequenceNumber { get; set; }
        public byte RequestedCommandCode { get; set; }
    }
}
