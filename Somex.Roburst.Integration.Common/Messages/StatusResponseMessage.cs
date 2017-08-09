using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    public class StatusResponseMessage : IMessage
    {
        public string Mode { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public MessageType MessageType
        {
            get { return Common.MessageType.StatusReesponse; }
            set { }
        }

    }
}
