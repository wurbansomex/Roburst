using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// Model of data returned from iAFIS when a set is requested
    /// KCarey 
    /// </summary>
    public class MouldSetResponseMessage : IMessage
    {

        public MouldSetResponseMessage()
        {
            this.MessageType = Common.MessageType.SampleSetResponse;
        }

        public MessageType MessageType { get; set; }
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
