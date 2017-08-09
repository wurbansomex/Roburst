using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somex.Roburst.Integration.Sockets
{
    public enum AlarmCode
    {
        NoActiveClient,
        NoClientConnected,
        SendDataError,
        ReceieveDataTimeout,
        UnknownReceiveError,
        ListenForIncomingDataError
    }

    
}
