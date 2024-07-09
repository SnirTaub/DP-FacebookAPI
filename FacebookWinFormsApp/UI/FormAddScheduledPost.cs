using System;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Logic.ScheduledPost;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormAddScheduledPost : Form
    {
        protected readonly FacadeScheduledPosts r_FacadeScheduledPosts;
        protected readonly ProxyUser r_LoggedInUser;

        public FormAddScheduledPost(ProxyUser i_LoggedInUser)
        {
            r_FacadeScheduledPosts = Singleton<FacadeScheduledPosts>.Instance;
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Now.AddMinutes(1);
        }

        protected virtual void buttonPost_Click(object sender, EventArgs e)
        {
            DateTime postDate;
            ePrivacyTypes privacyMode;
            string postBody = textBoxPostBody.Text;

            if (string.IsNullOrEmpty(postBody))
            {
                MessageBox.Show(Texts.EnterBodyStatus);
                return;
            }

            postDate = dateTimePicker.Value;
            privacyMode = GetPrivacy(comboBoxPrivacy.Text);
            r_FacadeScheduledPosts.CreateScheduledPost(postBody, postDate, r_LoggedInUser, privacyMode);
            Close();
        }

        protected ePrivacyTypes GetPrivacy(string i_Privacy)
        {
            ePrivacyTypes privacy = ePrivacyTypes.EVERYONE;

            switch (i_Privacy)
            {
                case "My friends":
                    privacy = ePrivacyTypes.ALL_FRIENDS;
                    break;
                case "Me":
                    privacy = ePrivacyTypes.SELF;
                    break;
            }

            return privacy;
        }
    }
}
