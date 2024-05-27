using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;
using BasicFacebookFeatures.UI;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private Album m_SelectedAlbum;
        private TeamManager m_TeamManager;
        private IList<Album> m_Albums;

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
                "user_friends",
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
            
            //selectedPagesLikesBox.Visible = true;
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
            listBoxLikes.DataSource = m_LoggedInUser.LikedPages;
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = Texts.Name;
            listBoxEvents.DataSource = m_LoggedInUser.EventsCreated;
        }

        private void listBoxLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikes.SelectedIndex != -1)
            {
                if (listBoxLikes.SelectedItems.Count == 1)
                {
                    Page selectedPage = (Page)listBoxLikes.SelectedItem;
                    pictureBox1.Image = selectedPage.ImageNormal;
                }
            }
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                m_SelectedAlbum = listBoxAlbums.SelectedItem as Album;

                if (m_SelectedAlbum.PictureAlbumURL != null)
                {
                    selectedAlbumCover.LoadAsync(m_SelectedAlbum.PictureAlbumURL);
                }
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

        private void myAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPost();
        }

        private void enableSchedulePostFeature()
        {
            labelWelcomePostScheduling.Text = Texts.MyScheduledPosts;
            buttonAddSchedulePost.Visible = true;
            buttonShowAllScheduledPosts.Visible = true;
            //fetchScheduledPosts();
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
