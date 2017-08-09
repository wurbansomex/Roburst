using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 Jul 2015
    /// </summary>
    public class MouldNumberAcknowledgeMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.SampleReceivedAcknowledge; }
            set { } 
        }

        public string MouldNumber { get; set; }
        public string ProfileNumber { get; set; } 
    }
}
