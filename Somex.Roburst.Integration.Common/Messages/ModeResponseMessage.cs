using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    public class ModeResponseMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.ModeResponse; }
            set { }
        }

        public ModesOfOperation Mode { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
