using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.UI;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic.ScheduledPost;
using BasicFacebookFeatures.Logic.BuildTeam;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private IList<Album> m_Albums;
        private ScheduledPostsManager m_ScheduledPostsManager;
        private IList<ScheduledPost> m_ScheduledPosts;
        private TeamManager m_TeamManager;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_TeamManager = new TeamManager();
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
                "user_posts",
                "user_friends"
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
                enableBuildTeamFeature();
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

        private bool buildTeam()
        {
            bool isTeamBuilt;
            bool fromHometown = checkBoxNearMe.Checked;
            Genders gender = Genders.Parse(comboBoxGender.Text);

            TeamSettings teamSettings = new TeamSettings(m_LoggedInUser, textBoxTeamName.Text, textBoxTeamPurpose.Text,
                int.Parse(comboBoxTeamSize.Text), int.Parse(comboBoxAgeFrom.Text),
                int.Parse(comboBoxAgeTo.Text), gender, fromHometown);

            isTeamBuilt = m_TeamManager.BuildTeam(teamSettings);

            return isTeamBuilt;
        }

        private void presentTeamInfo(string i_TeamName)
        {
            User teamManager = m_TeamManager.GetTeamManager(i_TeamName);
            int ageFrom = m_TeamManager.GetAgeFrom(i_TeamName);
            int ageTo = m_TeamManager.GetAgeTo(i_TeamName);
            Genders gender = m_TeamManager.GetGender(i_TeamName);
            string genderStr = gender == null ? "All gender" : gender.ToString(); ;
            string homeTownStr = m_TeamManager.GetTeamFromHometown(i_TeamName) ? $"From your hometown." : "Regardless of hometown";
            labelCreatedTeamTitle.Text = string.Format(@"{0}, {1} Team.", i_TeamName, m_TeamManager.GetTeamPurpose(i_TeamName));

            labelCreatedTeamDescription.Text = string.Format(@"Team Manager: {0},
                Searched for a team of {1}s,
                {2}
                between the ages of {3} and {4}.
                Potential team members found are:",
                teamManager.Name, genderStr, homeTownStr, ageFrom.ToString(), ageTo.ToString());

            if (listBoxTeamMembers.Items.Count > 0)
            {
                listBoxTeamMembers.Items.Clear();
            }

            listBoxTeamMembers.DisplayMember = Texts.Name;
            listBoxTeamMembers.DataSource = m_TeamManager.GetTeamMembers(i_TeamName);
        }

        private void presentAllTeams()
        {
            List<string> teams = m_TeamManager.GetTeamNames();

            if (listBoxTeams.DataSource != null)
            {
                listBoxTeams.DataSource = null;
            }

            if (listBoxTeams.Items.Count > 0)
            {
                listBoxTeams.Items.Clear();
            }

            listBoxTeams.DataSource = teams;
        }

        private void presentTeamMemberInfo(User i_TeamMember)
        {
            int age = AgeCalculator.CalculateAge(DateTime.Parse(i_TeamMember.Birthday));

            labelTeamPlayerInfo.Text = string.Format(@"{0}, {1}, From {2}.
Birthday: {3} ({4} years old).", i_TeamMember.Name, i_TeamMember.Gender, i_TeamMember.Hometown.Name, i_TeamMember.Birthday, age.ToString());

            pictureBoxTeamMember.Image = i_TeamMember.ImageSmall;
        }

        private void enableBuildTeamFeature()
        {
            labelLoginRequiredMessage.Enabled = false;
            labelLoginRequiredMessage.Visible = false;
            labelTeamBuildHeader.Enabled = true;
            labelTeamBuildHeader.Visible = true;
            labelTeamName.Enabled = true;
            labelTeamName.Visible = true;
            textBoxTeamName.Enabled = true;
            textBoxTeamName.Visible = true;
            textBoxTeamName.Text = "Team Name";
            labelTeamPurpose.Enabled = true;
            labelTeamPurpose.Visible = true;
            textBoxTeamPurpose.Enabled = true;
            textBoxTeamPurpose.Visible = true;
            textBoxTeamPurpose.Text = "Football";
            labelTeamSize.Enabled = true;
            labelTeamSize.Visible = true;
            comboBoxTeamSize.Enabled = true;
            comboBoxTeamSize.Visible = true;
            comboBoxTeamSize.Text = "11";
            labelAgeRange.Enabled = true;
            labelAgeRange.Visible = true;
            comboBoxAgeFrom.Enabled = true;
            comboBoxAgeFrom.Visible = true;
            comboBoxAgeFrom.Text = "18";
            labelTo.Enabled = true;
            labelTo.Visible = true;
            comboBoxAgeTo.Enabled = true;
            comboBoxAgeTo.Visible = true;
            comboBoxAgeTo.Text = "35";
            labelGender.Enabled = true;
            labelGender.Visible = true;
            comboBoxGender.Enabled = true;
            comboBoxGender.Visible = true;
            comboBoxGender.Text = "All";
            checkBoxNearMe.Enabled = true;
            checkBoxNearMe.Visible = true;
            checkBoxNearMe.Checked = true;
            buttonBuildTeam.Enabled = true;
            buttonBuildTeam.Visible = true;
            labelCreatedTeamHeader.Enabled = true;
            labelCreatedTeamHeader.Visible = true;
            labelCreatedTeamTitle.Enabled = true;
            labelCreatedTeamTitle.Visible = true;
            labelCreatedTeamDescription.Enabled = true;
            labelCreatedTeamDescription.Visible = true;
            listBoxTeamMembers.Enabled = true;
            listBoxTeamMembers.Visible = true;
            labelTeamPlayerInfo.Enabled = true;
            labelTeamPlayerInfo.Visible = true;
            labelTeams.Enabled = true;
            labelTeams.Visible = true;
            listBoxTeams.Enabled = true;
            listBoxTeams.Visible = true;
            pictureBoxTeamMember.Enabled = true;
            pictureBoxTeamMember.Visible = true;
            buttonRemoveTeam.Enabled = true;
            buttonRemoveTeam.Visible = true;
        }

        private void buttonBuildTeam_Click(object sender, EventArgs e)
        {
            try
            {
                bool isTeamBuilt = buildTeam();

                if (isTeamBuilt)
                {
                    presentTeamInfo(m_TeamManager.SelectedTeamName);
                    presentAllTeams();
                }
                else
                {
                    string teamExistsMessage = "Team already exists";
                    string caption = "Could not create another team with the same name";
                    MessageBox.Show(teamExistsMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException fe)
            {
                string errorMessage = "Please make sure that all the required properties have been filled with the required information.";
                string caption = "Could not build team!";
                MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeams.SelectedIndex > -1)
            {
                string selectedTeamName = listBoxTeams.SelectedItem as string;
                presentTeamInfo(selectedTeamName);
            }
        }

        private void listBoxTeamMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeamMembers.SelectedIndex > -1)
            {
                User selectedTeamMember = listBoxTeamMembers.SelectedItem as User;
                presentTeamMemberInfo(selectedTeamMember);
            }
        }

        private void buttonRemoveTeamMember_Click(object sender, EventArgs e)
        {
            if (listBoxTeamMembers.SelectedIndex > -1)
            {
                User teamMember = listBoxTeamMembers.SelectedItem as User;

                listBoxTeamMembers.Items.Remove(listBoxTeamMembers.SelectedItem);
                m_TeamManager.RemoveTeamMember(m_TeamManager.SelectedTeamName, teamMember);
            }
        }

        private void buttonRemoveTeam_Click(object sender, EventArgs e)
        {
            if (listBoxTeams.SelectedIndex > -1)
            {
                listBoxTeams.Items.Remove(listBoxTeams.SelectedItem);
                m_TeamManager.RemoveTeam(listBoxTeams.SelectedItem.ToString());
            }
        }
    }
}
