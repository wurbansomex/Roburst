using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrNAckMessage:IMessage
    {
        public MessageType MessageType
        {
            get
            {
                return Common.MessageType.NAckMessage;
            }
            set { }
        }
        public AgrNAckMessage() { }

        public AgrNAckMessage ( byte requestSequence, byte requestCommand){
            RequestedSequenceNumber = requestSequence;
            RequestedCommandCode = requestCommand;
        }

        public byte SequenceNumber { get; set; }
        public byte RequestedSequenceNumber { get; set; }
        public byte RequestedCommandCode { get; set; }
    }
}
