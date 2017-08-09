using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{

    /// <summary>
    /// Generic interface for component which builds outgoing messages from Roburst to Line Controller
    /// </summary>
    public interface IMessageBuilder
    {

        string BuildXmlFor(IMessage message); 

    }
}
