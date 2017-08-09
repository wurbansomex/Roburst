using System;
using System.Threading;


namespace CGC.Common.Security.IdleTime
{
    /// <summary>
    /// Runs a background check to determine if the idle time has exceeded the 
    /// allowed limit. Fires an IdleTimeElaspedMessage when it's exceeded andd stoped monitoring
    /// </summary>
    public class IdleTimeNotifier : IIdleTimeNotifier
    {
        public event EventHandler<IdleTimeElapsedEventArgs> IdleTimeElapsed;

        private Thread _backgroundThread;
        private bool _keepMonitoring = false;
        private int _maxAllowedIdleTime = 1800;

        public IdleTimeNotifier(int idleTime)
        {
            _maxAllowedIdleTime = idleTime;  

            this.DurationBeforeIdleTimeElapses = _maxAllowedIdleTime;
        }

        public double DurationBeforeIdleTimeElapses { get; private set; }

        public void StartMonitoring()
        {
            StopMonitoring();

            _keepMonitoring = true; 
            _backgroundThread = new Thread(x =>
            {
                while (_keepMonitoring)
                {
                    var idleTime = IdleTimeDetector.GetIdleTimeInfo();
                    if (idleTime.IdleTime.TotalSeconds >= _maxAllowedIdleTime)
                    {
                        OnIdleTimeElapsed(new IdleTimeElapsedEventArgs(new IdleTimeInfo() {
                             IdleTime = idleTime.IdleTime,
                             LastInputTime = idleTime.LastInputTime
                        }));

                    }

                    Thread.Sleep(2000);
                }
            });

            _backgroundThread.IsBackground = true;
            _backgroundThread.Start();
        }

        public void StopMonitoring()
        {
            _keepMonitoring = false;
            if (_backgroundThread != null)
                _backgroundThread.Join();
        }

        protected virtual void OnIdleTimeElapsed(IdleTimeElapsedEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<IdleTimeElapsedEventArgs> handler = IdleTimeElapsed;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Use the () operator to raise the event.
                handler(this, e);
            }
        }



    }
}
