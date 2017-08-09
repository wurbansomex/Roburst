using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrCavityNumberDataRequest:IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.CavityNumberDataRequest; }
            set { }
        }

        public byte SequenceNumber { get; set; }
    }
}
