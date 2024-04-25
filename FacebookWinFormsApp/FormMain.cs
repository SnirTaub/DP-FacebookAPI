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
                "email",
                "public_profile",
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
               // fetchUserInfo();
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

        //private void fetchUserInfo()
        //{
        //    pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        //    textboxEmail.Text = m_LoggedInUser?.Email;
        //    textboxBirthday.Text = m_LoggedInUser?.Birthday;
        //    textboxCity.Text = m_LoggedInUser.Location?.Name;
        //    selectedPagesLikesBox.Visible = true;
        //    selectedPostBox.Visible = true;
        //    fetchAlbums();
        //    fetchLikes();
        //    fetchPosts();
        //    fetchEvents();
        //}

        private void fetchAlbums()
        {

        }
    }
}
