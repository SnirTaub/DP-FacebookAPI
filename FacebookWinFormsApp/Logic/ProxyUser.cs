using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    class ProxyUser
    {
        private readonly User r_LoggedInUser;

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return r_LoggedInUser.Posts;
            }

            set
            {
                r_LoggedInUser.Posts = value;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_LoggedInUser.Albums;
            }

            set
            {
                r_LoggedInUser.Albums = value;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return r_LoggedInUser.Events;
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                return r_LoggedInUser.LikedPages;
            }

            set
            {
                r_LoggedInUser.LikedPages = value;
            }
        }

        public string PictureNormalURL
        {
            get
            {
                return r_LoggedInUser.PictureNormalURL;
            }
        }

        public string Email
        {
            get
            {
                return r_LoggedInUser.Email;
            }

            set
            {
                r_LoggedInUser.Email = value;
            }
        }

        public string Birthday
        {
            get
            {
                return r_LoggedInUser.Birthday;
            }

            set
            {
                r_LoggedInUser.Birthday = value;
            }
        }

        public City Location
        {
            get
            {
                return r_LoggedInUser.Location;
            }

            set
            {
                r_LoggedInUser.Location = value;
            }
        }

        public ProxyUser(User i_User)
        {
            r_LoggedInUser = i_User;
            addMockedAlbumsIfEmpty();
            addMockedPostsIfEmpty();
        }

        public Status PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null,
            string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null)
        {
            Status status = null;

            // FB Api doesn't give permissions to have post status. we will behave like it was posted.
            try
            {
                status = r_LoggedInUser.PostStatus(i_StatusText, i_PrivacyParameterValue);
            }
            catch
            {
            }

            return status;
        }

        private void addMockedAlbumsIfEmpty()
        {
            // In case FB will throw authorization error, this is a dummy album
            if (Albums is null || Albums.Count == 0)
            {
                Albums = new FacebookObjectCollection<Album>() { new Album() };
            }
        }

        private void addMockedPostsIfEmpty()
        {
            // In case FB will throw authorization error, this is a dummy post
            if (Posts is null || Posts.Count == 0)
            {
                Posts = new FacebookObjectCollection<Post>() { new Post() };
            }
        }
    }
}