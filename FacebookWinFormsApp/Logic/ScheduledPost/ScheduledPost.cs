using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.ScheduledPost
{
    internal class ScheduledPost
    {
        private static int s_Id = 1;
        private readonly ProxyUser r_LoggedInUser;
        private readonly FacadeScheduledPosts r_ScheduledPostsManager;
        private TimerEngine m_Timer;
        internal string PostBody { get; set; }
        internal bool IsPosted { get; set; } = false;
        internal ePrivacyTypes Privacy { get; set; }
        internal DateTime ScheduledPostTimeToUpload { get; }
        internal int ScheduledPostId { get; }
        public event Action PostShared;

        public ScheduledPost(string i_CurrentScheduledPost,
            DateTime i_ScheduledPostTimeToUpload,
            ProxyUser i_LoggedInUser,
            ePrivacyTypes i_Privacy)
        {
            PostBody = i_CurrentScheduledPost;
            ScheduledPostTimeToUpload = i_ScheduledPostTimeToUpload;
            r_LoggedInUser = i_LoggedInUser;
            ScheduledPostId = s_Id;
            Privacy = i_Privacy;
            incrementId();
            setPostTime();
        }

        private void setPostTime()
        {
            int interval = 10000;

            m_Timer = new TimerEngine(ScheduledPostTimeToUpload);
            m_Timer.TimerElapsed += Timer_Elapsed;
            m_Timer.SetTimer(interval);
        }

        private static void incrementId()
        {
            s_Id++;
        }

        internal void StopTimer()
        {
            m_Timer.StopTimer();
        }

        protected virtual void Timer_Elapsed()
        {
            r_LoggedInUser.PostStatus(i_StatusText: PostBody, i_PrivacyParameterValue: Privacy.ToString());
            IsPosted = true;
            OnPostShared();
        }

        protected virtual void OnPostShared()
        {
            if (PostShared != null)
            {
                PostShared.Invoke();
            }
        }
    }
}
