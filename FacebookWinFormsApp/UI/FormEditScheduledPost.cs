using BasicFacebookFeatures.Logic.ScheduledPost;
using BasicFacebookFeatures.UI;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormEditScheduledPost : FormAddScheduledPost
    {
        private readonly DataGridView r_ScheduledPostDataGrid;
        public int PostId { get; }

        public FormEditScheduledPost(ScheduledPostsManager i_ScheduledPostManager,
            User i_LoggedInUser,
            int i_PostId,
            DataGridView i_ScheduledPostDataGrid) : base(i_ScheduledPostManager, i_LoggedInUser)
        {
            PostId = i_PostId;
            r_ScheduledPostDataGrid = i_ScheduledPostDataGrid;
            InitializeComponent();
        }

        private void FormEditScheduledPost_Load(object sender, EventArgs e)
        {
            buttonPost.Text = Texts.Update;
            labelDateToPost.Visible = false;
            dateTimePicker.Visible = false;
            textBoxPostBody.Text = UiUtils.GetSelectedRow(r_ScheduledPostDataGrid).Cells["PostBody"].Value.ToString();
            comboBoxPrivacy.Text = UiUtils.GetSelectedRow(r_ScheduledPostDataGrid).Cells["postPrivacyLevel"].Value.ToString();
        }

        protected override void buttonPost_Click(object sender, EventArgs e)
        {
            ePrivacyType privacyMode;
            string postBody = textBoxPostBody.Text;

            if (string.IsNullOrEmpty(postBody))
            {
                MessageBox.Show(Texts.EnterBodyStatus);
                return;
            }

            privacyMode = GetPrivacy(comboBoxPrivacy.Text);
            r_ScheduledPostsManager.EditScheduledPost(PostId, postBody, privacyMode);
            Close();
        }
    }
}
