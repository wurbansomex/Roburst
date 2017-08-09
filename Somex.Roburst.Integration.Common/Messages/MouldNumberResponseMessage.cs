using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    public class MouldNumberResponseMessage : IMessage
    {

        public MouldNumberResponseMessage()
        {
            this.MessageType = Common.MessageType.SampleResponse;
        }

        public MessageType MessageType
        {
            get;
            set;
        }

        public string MouldNumber { get; set; }
        public string ProfileNumber { get; set; } 
    }
}
