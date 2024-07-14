using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.UI;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic.ScheduledPost;
using BasicFacebookFeatures.Logic.BuildTeam;
using BasicFacebookFeatures.Logic;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private ProxyUser m_LoggedInUser;
        private LoginResult m_LoginResult;
        private IList<Album> m_Albums;
        private FacadeScheduledPosts m_FacadeScheduledPosts = Singleton<FacadeScheduledPosts>.Instance;
        private TeamManager m_TeamManager;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_TeamManager = new TeamManager();
        }

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

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = new ProxyUser(m_LoginResult.LoggedInUser);
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
            bindingSourceUser.DataSource = m_LoggedInUser;
            bindingSourceCity.DataSource = new City();
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            textBoxPagesLikes.Visible = true;
            selectedPostBox.Visible = true;
            new Thread(fetchAlbums).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchLikes).Start();
            new Thread(fetchEvents).Start();
        }
        
        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = Texts.Name));
            m_Albums = m_LoggedInUser.Albums;
            foreach (Album album in m_Albums)
            {
                if (album.Name != null)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }
                else
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("dummy album")));
                }

                if (listBoxAlbums.Items.Count == 25)
                {
                    break;
                }
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null || post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                }
                else if (m_LoggedInUser.Posts.Count == 1)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("dummy post")));
                }

                if (listBoxPosts.Items.Count == 25)
                {
                    break;
                }
            }
        }

        private void fetchLikes()
        {
            listBoxLikes.Invoke(new Action(() => listBoxLikes.Items.Clear()));
            listBoxLikes.Invoke(new Action(() => listBoxLikes.DisplayMember = Texts.Name));
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxLikes.Invoke(new Action(() => listBoxLikes.Items.Add(page)));
            }

            if (listBoxLikes.Items.Count == 0)
            {
                labelLikedPages.Invoke(new Action(() => labelLikedPages.Text = Texts.NoPagesFound));
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            foreach (Event facebookEvent in m_LoggedInUser.Events)
            {
                if (facebookEvent.Description != null)
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(facebookEvent)));
                }

                if (listBoxEvents.Items.Count == 25)
                {
                    break;
                }
            }

            if (listBoxEvents.Items.Count == 0)
            {
                labelEvents.Invoke(new Action(() => labelEvents.Text = Texts.NoEventsFound));
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
            foreach (ScheduledPost scheduledPost in m_FacadeScheduledPosts.GetScheduledPostsAsList())
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
                UiUtils.GetPrivacyText(i_ScheduledPost.Privacy),
                postStatus);
        }

        private void dataGridPostScheduler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditSelectedSchedulePost.Visible = true;
        }

        private void buttonAddSchedulePost_Click(object sender, EventArgs e)
        {
            FormAddScheduledPost scheduledPostForm = new FormAddScheduledPost(m_LoggedInUser);
            scheduledPostForm.ShowDialog();
            fetchScheduledPosts();
        }

        private void buttonRemoveScheduledPost_Click(object sender, EventArgs e)
        {
            ScheduledPost postToRemove;
            int postIdToChange = int.Parse(UiUtils.GetSelectedRow(dataGridPostScheduler).Cells["PostId"].Value.ToString());

            if (m_FacadeScheduledPosts.IsPostContained(postIdToChange))
            {
                m_FacadeScheduledPosts.RemoveScheduledPost(postIdToChange);
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
            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost schedulePost in m_FacadeScheduledPosts.GetPublishedScheduledPostsAsList())
            {
                addRowToScheduledPostsGrid(schedulePost);
            }
        }

        private void buttonUnpublishedPosts_Click(object sender, EventArgs e)
        {
            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost schedulePost in m_FacadeScheduledPosts.GetUnpublishedScheduledPostsAsList())
            {
                addRowToScheduledPostsGrid(schedulePost);
            }
        }

        private void buttonEditSelectedSchedulePost_Click(object sender, EventArgs e)
        {
            FormEditScheduledPost scheduledPostForm;
            int postIdToChange = int.Parse(UiUtils.GetSelectedRow(dataGridPostScheduler).Cells["postId"].Value.ToString());

            if (m_FacadeScheduledPosts.IsPostContained(postIdToChange) &&
                !m_FacadeScheduledPosts.GetPostById(postIdToChange).IsPosted)
            {
                scheduledPostForm = new FormEditScheduledPost(m_LoggedInUser, postIdToChange, dataGridPostScheduler);
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
            IList<ScheduledPost> currentScheduledPosts = m_FacadeScheduledPosts.GetScheduledPostsAsList();

            dataGridPostScheduler.Rows.Clear();
            foreach (ScheduledPost scheduledPost in currentScheduledPosts)
            {
                if (scheduledPost.PostBody.Contains(searchText))
                {
                    addRowToScheduledPostsGrid(scheduledPost);
                }
            }
        }

        private bool buildTeam() // changed
        {
            bool isTeamBuilt;
            bool fromHometown = checkBoxNearMe.Checked;
            Genders gender = Genders.Parse(comboBoxGender.Text);

            TeamSettings teamSettings = new TeamSettings(m_LoggedInUser, textBoxTeamName.Text, textBoxTeamPurpose.Text,
                int.Parse(comboBoxTeamSize.Text), int.Parse(comboBoxAgeFrom.Text),
                int.Parse(comboBoxAgeTo.Text), gender, fromHometown);

            List<ITeamBuildingStrategy> strategies = new List<ITeamBuildingStrategy>();

            if (teamSettings.AgeFrom != null && teamSettings.AgeTo != null)
            {
                strategies.Add(new AgeStrategy());
            }

            if (teamSettings.Gender != null)
            {
                strategies.Add(new GenderStrategy());
            }

            if (teamSettings.FromHometown != null)
            {
                strategies.Add(new HometownStrategy());
            }

            isTeamBuilt = m_TeamManager.BuildTeam(teamSettings, strategies);

            return isTeamBuilt;
        }

        private void presentTeamInfo(string i_TeamName)
        {
            ProxyUser teamManager = m_TeamManager.GetTeamManager(i_TeamName);
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

            listBoxTeamMembers.DisplayMember = null;

            /*if (listBoxTeamMembers.Items.Count > 0)
            {
                listBoxTeamMembers.Items.Clear();
            }*/

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
            int age = AgeCalculator.CalculateAgeFromString(i_TeamMember.Birthday);
            string name = i_TeamMember.Name != null ? i_TeamMember.Name : "Missing name";
            Genders gender = new Genders(i_TeamMember.Gender);
            string hometownName;
            string birthDay = i_TeamMember.Birthday != null ? i_TeamMember.Birthday : "Missing birthday";

            if (i_TeamMember.Hometown != null && i_TeamMember.Hometown.Name != null)
            {
                hometownName = i_TeamMember.Hometown.Name;
            }
            else
            {
                hometownName = "Missing hometown";
            }

            labelTeamPlayerInfo.Text = string.Format(@"{0},
{1},
From {2}.
Birthday: {3} ({4} years old).", name, gender, hometownName, birthDay, age.ToString());

            pictureBoxTeamMember.Image = i_TeamMember.ImageSmall;
        }

        private void clearInfoBoxes()
        {
            labelCreatedTeamTitle.Text = "Team Title";
            labelCreatedTeamDescription.Text = "Team Description";
            labelTeamPlayerInfo.Text = "Player Information";
            pictureBoxTeamMember.Image = null;
        }

        private void enableBuildTeamFeature()
        {
            labelLoginRequiredMessage.Enabled = false;
            labelLoginRequiredMessage.Visible = false;
            buttonRemoveTeamMember.Enabled = true;
            buttonRemoveTeamMember.Visible = true;
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
                ProxyUser teamMember = listBoxTeamMembers.SelectedItem as ProxyUser;

                m_TeamManager.RemoveTeamMember(m_TeamManager.SelectedTeamName, teamMember);

                clearInfoBoxes();

                listBoxTeamMembers.DataSource = null;
                listBoxTeamMembers.DataSource = m_TeamManager.GetTeamMembers(m_TeamManager.SelectedTeamName);
            }
        }

        private void buttonRemoveTeam_Click(object sender, EventArgs e)
        {
            if (listBoxTeams.SelectedIndex > -1)
            {
                string selectedTeam = listBoxTeams.SelectedItem.ToString();

                if (m_TeamManager.SelectedTeamName == selectedTeam)
                {
                    listBoxTeamMembers.DataSource = null;
                    clearInfoBoxes();
                }

                m_TeamManager.RemoveTeam(selectedTeam);

                listBoxTeams.DataSource = null;
                listBoxTeams.DataSource = m_TeamManager.Teams;
            }
        }
    }
}
