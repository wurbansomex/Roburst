using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// Ack sent to IAFIS in response to set list from iAFIS
    /// KCarey 
    /// </summary>
    public class MouldSetAcknowledgeMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.SampleSetReceivedAcknoowledge; }
            set { }
        }

        public string Profile { get; set; }
        public int SetQuantity { get; set; }

        /// <summary>
        /// Incrementing number, each time a set is requested. 
        /// </summary>
        public int SetNumber { get; set; }

        /// <summary>
        /// List of mould numbers
        /// </summary>
        public List<string> MouldNumbers { get; set; } 
    }
}

