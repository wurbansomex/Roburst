﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    public interface IMessage
    {
        MessageType MessageType { get; set; } 
    }
}
