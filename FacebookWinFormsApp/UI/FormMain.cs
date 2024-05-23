using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.UI;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic.ScheduledPost;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private IList<Album> m_Albums;
        private ScheduledPostsManager m_ScheduledPostsManager;
        private IList<ScheduledPost> m_ScheduledPosts;
      
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

            m_ScheduledPostsManager = new ScheduledPostsManager();
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                enableSchedulePostFeature();
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
            textBoxEmail.Text = m_LoggedInUser?.Email;
            textBoxBirthday.Text = m_LoggedInUser?.Birthday;
            textBoxCity.Text = m_LoggedInUser.Location?.Name;
            textBoxEvents.Visible = true;
            textBoxPagesLikes.Visible = true;
            selectedPostBox.Visible = true;
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
            listBoxLikes.DisplayMember = Texts.Name;
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxLikes.Items.Add(page);
            }

            if (listBoxLikes.Items.Count == 0)
            {
                labelLikedPages.Text = Texts.NoPagesFound;
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            foreach (Event facebookEvent in m_LoggedInUser.Events)
            {
                if (facebookEvent.Description != null)
                {
                    listBoxEvents.Items.Add(facebookEvent);
                }

                if (listBoxEvents.Items.Count == 25)
                {
                    break;
                }
            }

            if (listBoxEvents.Items.Count == 0)
            {
                labelEvents.Text = Texts.NoEventsFound;
            }
        }

        private void displaySelectedLikedPages()
        {
            Page selectedPage;

            if (listBoxLikes.SelectedItems.Count == 1)
            {
                selectedPage = listBoxLikes.SelectedItem as Page;
                textBoxPagesLikes.Text = string.Format(Texts.PageDetails, selectedPage.Name, selectedPage.Description);
            }
        }

        private void displaySelectedAlbum()
        {
            Album selectedAlbum;

            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    selectedAlbumCover.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
            }
        }

        private void displaySelectedEvents()
        {
            Event selectedEvent;

            if(listBoxEvents.SelectedItems.Count == 1)
            {
                selectedEvent = listBoxPosts.SelectedItem as Event;
                selectedPostBox.Text = string.Format(Texts.EventDetails, selectedEvent?.AttendingCount, selectedEvent?.Description);
            }
        }

        private void displaySelectedPost()
        {
            Post selectedPost;
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                selectedPost = listBoxPosts.SelectedItem as Post;
                selectedPostBox.Text = string.Format(Texts.PostDetails, selectedPost?.CreatedTime, selectedPost?.Message);
            }
        }

        private void myAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPost();
        }

        private void listBoxLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedLikedPages();
        }

        private void textBoxEvents_TextChanged(object sender, EventArgs e)
        {
            displaySelectedEvents();
        }

        private void enableSchedulePostFeature()
        {
            labelWelcomePostScheduling.Text = Texts.MyScheduledPosts;
            buttonAddSchedulePost.Visible = true;
            buttonShowAllScheduledPosts.Visible = true;
            fetchScheduledPosts();
        }

        private void scheduledPostPosted()
        {
            fetchScheduledPosts();
        }

        private void fetchScheduledPosts()
        {
            dataGridPostScheduler.Rows.Clear();
            m_ScheduledPosts = m_ScheduledPostsManager.GetScheduledPostsAsList();
            foreach (ScheduledPost scheduledPost in m_ScheduledPosts)
            {
                addRowToScheduledPostsGrid(scheduledPost);
                scheduledPost.PostShared += scheduledPostPosted;
            }

            dataGridPostScheduler.Refresh();
            if (dataGridPostScheduler.Rows.Count > 0)
            {
                buttonRemoveScheduledPost.Visible = true;
                buttonEditSelectedSchedulePost.Visible = true;
                buttonPublishedPosts.Visible = true;
                buttonUnpublishedPosts.Visible = true;
                buttonViewPostBody.Visible = true;
                buttonSearch.Visible = true;
                textBoxSearch.Visible = true;
            }
            else
            {
                buttonRemoveScheduledPost.Visible = false;
                buttonEditSelectedSchedulePost.Visible = false;
                buttonPublishedPosts.Visible = false;
                buttonUnpublishedPosts.Visible = false;
                buttonViewPostBody.Visible = false;
                buttonSearch.Visible = false;
                textBoxSearch.Visible = false;
            }
        }

        private void addRowToScheduledPostsGrid(ScheduledPost i_ScheduledPost)
        {
            string postStatus = Texts.Pending;

            if (i_ScheduledPost.IsPosted)
            {
                postStatus = Texts.Posted;
            }

            dataGridPostScheduler.Rows.Add(i_ScheduledPost.ScheduledPostId,
                i_ScheduledPost.PostBody,
                i_ScheduledPost.ScheduledPostTimeToUpload,
                UiUtils.getPrivacyText(i_ScheduledPost.Privacy),
                postStatus);
        }

        private void dataGridPostScheduler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditSelectedSchedulePost.Visible = true;
        }

        private void buttonAddSchedulePost_Click(object sender, EventArgs e)
        {
            FormAddScheduledPost scheduledPostForm = new FormAddScheduledPost(m_ScheduledPostsManager, m_LoggedInUser);
            scheduledPostForm.ShowDialog();
            fetchScheduledPosts();
        }

        private void buttonRemoveScheduledPost_Click(object sender, EventArgs e)
        {
            ScheduledPost postToRemove;
            int postIdToChange = int.Parse(UiUtils.GetSelectedRow(dataGridPostScheduler).Cells["PostId"].Value.ToString());

            if (m_ScheduledPostsManager.IsPostContained(postIdToChange))
            {
                postToRemove = m_ScheduledPostsManager.GetPostById(postIdToChange);
                postToRemove.RemovePostFromList();
                fetchScheduledPosts();
            }
            else
            {
                MessageBox.Show(Texts.RemovePost);
            }
        }

        private void buttonShowAllScheduledPosts_Click(object sender, EventArgs e)
        {
            fetchScheduledPosts();
        }

        private void buttonPublishedPosts_Click(object sender, EventArgs e)
        {
            IList<ScheduledPost> currentScheduledPosts = m_ScheduledPostsManager.GetScheduledPostsAsList();

            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost scheduledPost in currentScheduledPosts)
            {
                if (scheduledPost.IsPosted == true)
                {
                    addRowToScheduledPostsGrid(scheduledPost);
                }
            }
        }

        private void buttonUnpublishedPosts_Click(object sender, EventArgs e)
        {
            IList<ScheduledPost> currentScheduledPosts = m_ScheduledPostsManager.GetScheduledPostsAsList();

            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost scheduledPost in currentScheduledPosts)
            {
                if (scheduledPost.IsPosted == false)
                {
                    addRowToScheduledPostsGrid(scheduledPost);
                }
            }
        }

        private void buttonEditSelectedSchedulePost_Click(object sender, EventArgs e)
        {
            FormEditScheduledPost scheduledPostForm;
            int postIdToChange = int.Parse(UiUtils.GetSelectedRow(dataGridPostScheduler).Cells["postId"].Value.ToString());

            if (m_ScheduledPostsManager.IsPostContained(postIdToChange) &&
                !m_ScheduledPostsManager.GetPostById(postIdToChange).IsPosted)
            {
                scheduledPostForm = new FormEditScheduledPost(m_ScheduledPostsManager, m_LoggedInUser, postIdToChange, dataGridPostScheduler);
                scheduledPostForm.ShowDialog();
                fetchScheduledPosts();
            }
            else
            {
                MessageBox.Show(Texts.EditPost);
            }
        }

        private void buttonViewPostBody_Click(object sender, EventArgs e)
        {
            string postIdToChange = UiUtils.GetSelectedRow(dataGridPostScheduler).Cells["PostBody"].Value.ToString();
            MessageBox.Show(postIdToChange, Texts.PostBody);
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.ForeColor == Color.Gray)
            {
                textBoxSearch.Text = string.Empty;
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.ForeColor = Color.Gray;
                textBoxSearch.Text = Texts.SearchPostBody;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            IList<ScheduledPost> currentScheduledPosts = m_ScheduledPostsManager.GetScheduledPostsAsList();

            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost scheduledPost in currentScheduledPosts)
            {
                if (scheduledPost.PostBody.Contains(searchText))
                {
                    addRowToScheduledPostsGrid(scheduledPost);
                }
            }
        }
    }
}
