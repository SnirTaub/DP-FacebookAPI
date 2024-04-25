using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private IList<Album> m_Albums;
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                /// add any relevant permissions
                "user_birthday",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_photos",
                "user_posts"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            }

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void fetchUserInfo()
        {
            //pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            textBoxEmail.Text = m_LoggedInUser?.Email;
            textBoxBirthday.Text = m_LoggedInUser?.Birthday;
            textBoxCity.Text = m_LoggedInUser.Location?.Name;
            
            //selectedPagesLikesBox.Visible = true;
            //selectedPostBox.Visible = true;
            fetchAlbums();
            fetchLikes();
            fetchPosts();
            fetchEvents();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = Texts.Name;
            m_Albums = m_LoggedInUser.Albums;
            foreach (Album album in m_Albums)
            {
                listBoxAlbums.Items.Add(album);
                if (listBoxAlbums.Items.Count == 25)
                {
                    break;
                }
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                labelAlbums.Text = Texts.NoAlbumsFound;
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post);
                    }
                    else if (post.Caption != null) 
                    {
                        listBoxPosts.Items.Add(post);
                    }

                    if (listBoxPosts.Items.Count == 25)
                    {
                        break;
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    labelPosts.Text = Texts.NoPostsFound;
                }
            }
            catch
            {
                listBoxPosts.Items.Add("First post");
                listBoxPosts.Items.Add("Second post");
                listBoxPosts.Items.Add("Third post");
            }
        }

        private void fetchLikes()
        {
            listBoxLikes.Items.Clear();
            listBoxLikes.DisplayMember = "Name";
            listBoxLikes.DataSource = m_LoggedInUser.LikedPages;
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            listBoxEvents.DataSource = m_LoggedInUser.EventsCreated;
        }
    }
}
