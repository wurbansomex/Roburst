using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    /// </summary>
    public class StatusRequestMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.StatusRequest; }
            set { }
        }
    }
}
