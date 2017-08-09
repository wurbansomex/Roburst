using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somex.Roburst.Integration.Sockets
{
    public static class Extensions
    {

        /// <summary>
        /// Pad alarm codes left with 4 zeros
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
       public static string PadLeftWithZeros(this AlarmCode code)
       {
           return ((int)code).ToString("D4");
       }


    }
}
