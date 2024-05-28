using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Logic.ScheduledPost
{
    internal class ScheduledPostsManager
    {
        private readonly Dictionary<int, ScheduledPost> r_Posts = new Dictionary<int, ScheduledPost>();

        internal void AddScheduledPost(ScheduledPost i_Post)
        {
            r_Posts.Add(i_Post.ScheduledPostId, i_Post);
        }

        internal void RemoveScheduledPost(int i_PostId)
        {
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

        internal void EditScheduledPost(int i_PostId, string i_PostBody, ePrivacyTypes i_Privacy)
        {
            r_Posts[i_PostId].PostBody = i_PostBody;
            r_Posts[i_PostId].Privacy = i_Privacy;
        }
    }
}
