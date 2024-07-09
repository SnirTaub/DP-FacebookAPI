using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.ScheduledPost
{
    internal class FacadeScheduledPosts
    {
        private readonly Dictionary<int, ScheduledPost> r_Posts = new Dictionary<int, ScheduledPost>();

        public event Action PostShared;

        private FacadeScheduledPosts()
        {
        }

        private void addScheduledPost(ScheduledPost i_Post)
        {
            r_Posts.Add(i_Post.ScheduledPostId, i_Post);
        }

        internal void RemoveScheduledPost(int i_PostId)
        {
            ScheduledPost currentPost = GetPostById(i_PostId);
            currentPost.StopTimer();
            r_Posts.Remove(i_PostId);
        }

        internal bool IsPostContained(int i_PostId)
        {
            return r_Posts.ContainsKey(i_PostId);
        }

        internal ScheduledPost GetPostById(int i_PostId)
        {
            r_Posts.TryGetValue(i_PostId, out ScheduledPost post);
            return post;
        }

        internal IList<ScheduledPost> GetScheduledPostsAsList()
        {
            return r_Posts.Values.ToList();
        }

        internal IList<ScheduledPost> GetUnpublishedScheduledPostsAsList()
        {
            return r_Posts.Values.Where(post => !post.IsPosted).ToList();
        }

        internal IList<ScheduledPost> GetPublishedScheduledPostsAsList()
        {
            return r_Posts.Values.Where(post => !post.IsPosted).ToList();
        }

        internal void EditScheduledPost(int i_PostId, string i_PostBody, ePrivacyTypes i_Privacy)
        {
            r_Posts[i_PostId].PostBody = i_PostBody;
            r_Posts[i_PostId].Privacy = i_Privacy;
        }

        internal void CreateScheduledPost(string i_PostBody, DateTime i_PostDate, ProxyUser i_LoggedInUser, ePrivacyTypes i_PrivacyMode)
        {
            ScheduledPost newPost = new ScheduledPost(i_PostBody, i_PostDate, i_LoggedInUser, i_PrivacyMode);
            newPost.PostShared += scheduledPostPosted;
            this.addScheduledPost(newPost);
        }

        protected virtual void scheduledPostPosted()
        {
            if (PostShared != null)
            {
                PostShared.Invoke();
            }
        }
    }
}