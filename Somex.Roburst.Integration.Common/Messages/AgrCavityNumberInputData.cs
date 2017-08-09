using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrCavityNumberInputData:IMessage
    {
        public MessageType MessageType
        {
            get
            {
                return MessageType.CavityNumberInputData;
            }
            set { }
        }

        public bool BottleNumberNotKnown { get; set; }
        public byte CavityNumber { get; set; }
        public byte SequenceNumber { get; set; }
        public byte CommandCode { get; set; }
    }
}
