using System;
namespace CGC.Common.Security.IdleTime
{
    interface IIdleTimeNotifier
    {
        double DurationBeforeIdleTimeElapses { get; }
        void StartMonitoring();
        void StopMonitoring();
    }
}
