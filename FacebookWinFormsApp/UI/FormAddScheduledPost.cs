using System;
using BasicFacebookFeatures.Logic.ScheduledPost;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormAddScheduledPost : Form
    {
        protected readonly ScheduledPostsManager r_ScheduledPostsManager;
        protected readonly User r_LoggedInUser;
        public FormAddScheduledPost(ScheduledPostsManager i_ScheduledPostsManager, User i_LoggedInUser)
        {
            r_ScheduledPostsManager = i_ScheduledPostsManager;
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Now.AddMinutes(1);
        }

        protected virtual void buttonPost_Click(object sender, EventArgs e)
        {
            DateTime postDate;
            ePrivacyType privacyMode;
            string postBody = textBoxPostBody.Text;

            if (string.IsNullOrEmpty(postBody))
            {
                MessageBox.Show(Texts.EnterBodyStatus);
                return;
            }

            postDate = dateTimePicker.Value;
            privacyMode = GetPrivacy(comboBoxPrivacy.Text);
            new ScheduledPost(postBody, postDate, r_ScheduledPostsManager, r_LoggedInUser, privacyMode);
            Close();
        }

        protected ePrivacyType GetPrivacy(string i_Privacy)
        {
            ePrivacyType privacy = ePrivacyType.EVERYONE;

            switch (i_Privacy)
            {
                case "My friends":
                    privacy = ePrivacyType.ALL_FRIENDS;
                    break;
                case "Me":
                    privacy = ePrivacyType.SELF;
                    break;
            }

            return privacy;
        }
    }
}
