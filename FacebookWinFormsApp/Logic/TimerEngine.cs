using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Logic
{
    internal class TimerEngine
    {
        private Timer m_TimeUntilUpload;
        private readonly DateTime r_EndTime;
        public event Action TimerElapsed;
        public event Action TimerTickBeforeElapsed;

        public TimerEngine(DateTime i_EndTime)
        {
            r_EndTime = i_EndTime;
        }

        internal void SetTimer(int i_Interval)
        {
            m_TimeUntilUpload = new Timer
            {
                Interval = i_Interval
            };

            m_TimeUntilUpload.Tick += Timer_Tick;
            m_TimeUntilUpload.Start();
        }

        internal void StopTimer()
        {
            m_TimeUntilUpload.Stop();
        }

        protected virtual void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, r_EndTime) > 0)
            {
                OnTimerElapsed(sender, e);
                StopTimer();

            }
            else
            {
                OnTimerTickBeforeElapsed(sender, e);
            }
        }

        protected virtual void OnTimerElapsed(object sender, EventArgs e)
        {
            if (TimerElapsed != null)
            {
                TimerElapsed.Invoke();
            }
        }

        protected virtual void OnTimerTickBeforeElapsed(object sender, EventArgs e)
        {
            if (TimerTickBeforeElapsed != null)
            {
                TimerTickBeforeElapsed.Invoke();
            }
        }
    }
}