using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Common.Security.IdleTime
{
        public class IdleTimeElapsedEventArgs : EventArgs
        {
            public IdleTimeInfo IdleTimeData { get; set; }

            public IdleTimeElapsedEventArgs(IdleTimeInfo idleTimeData)
            {
                this.IdleTimeData = idleTimeData;
            }
        }
    }
