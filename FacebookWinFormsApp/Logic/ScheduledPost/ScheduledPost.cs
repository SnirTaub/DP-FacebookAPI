using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.ScheduledPost
{
    internal class ScheduledPost
    {
        private static int s_Id = 1;
        private readonly User r_LoggedInUser;
        private readonly ScheduledPostsManager r_ScheduledPostsManager;
        private TimerEngine m_Timer;
        internal string PostBody { get; set; }
        internal bool IsPosted { get; set; } = false;
        internal ePrivacyTypes Privacy { get; set; }
        internal DateTime ScheduledPostTimeToUpload { get; }
        internal int ScheduledPostId { get; }
        public event Action PostShared;

        public ScheduledPost(string i_CurrentScheduledPost,
            DateTime i_ScheduledPostTimeToUpload,
            ScheduledPostsManager i_ScheduledPostsManager,
            User i_LoggedInUser,
            ePrivacyTypes i_Privacy)
        {
            PostBody = i_CurrentScheduledPost;
            ScheduledPostTimeToUpload = i_ScheduledPostTimeToUpload;
            r_ScheduledPostsManager = i_ScheduledPostsManager;
            r_LoggedInUser = i_LoggedInUser;
            ScheduledPostId = s_Id;
            Privacy = i_Privacy;
            incrementId();
            setPostTime();
            addPostToList();
        }

        private void setPostTime()
        {
            int interval = 10000;

            m_Timer = new TimerEngine(ScheduledPostTimeToUpload);
            m_Timer.TimerElapsed += Timer_Elapsed;
            m_Timer.SetTimer(interval);
        }

        private void addPostToList()
        {
            r_ScheduledPostsManager.AddScheduledPost(this);
        }

        private static void incrementId()
        {
            s_Id++;
        }

        internal void RemovePostFromList()
        {
            m_Timer.StopTimer();
            r_ScheduledPostsManager.RemoveScheduledPost(this.ScheduledPostId);
        }
        
        protected virtual void Timer_Elapsed()
        {
            try
            {
                r_LoggedInUser.PostStatus(i_StatusText: PostBody, i_PrivacyParameterValue: Privacy.ToString());
                IsPosted = true;
                OnPostShared();
            }
            catch
            {
                IsPosted = true;
                OnPostShared();
            }
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
