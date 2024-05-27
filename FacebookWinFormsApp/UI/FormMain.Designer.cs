namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.selectedPostBox = new System.Windows.Forms.TextBox();
            this.selectedAlbumCover = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLikes = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMyBirthday = new System.Windows.Forms.Label();
            this.labelMyCity = new System.Windows.Forms.Label();
            this.labelMyEmail = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabScheduleAPost = new System.Windows.Forms.TabPage();
            this.buttonEditSelectedSchedulePost = new System.Windows.Forms.Button();
            this.buttonAddSchedulePost = new System.Windows.Forms.Button();
            this.buttonRemoveScheduledPost = new System.Windows.Forms.Button();
            this.buttonPublishedPosts = new System.Windows.Forms.Button();
            this.buttonShowAllScheduledPosts = new System.Windows.Forms.Button();
            this.buttonViewPostBody = new System.Windows.Forms.Button();
            this.buttonUnpublishedPosts = new System.Windows.Forms.Button();
            this.dataGridPostScheduler = new System.Windows.Forms.DataGridView();
            this.postId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postPrivacyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWelcomePostScheduling = new System.Windows.Forms.Label();
            this.tabBuildTeam = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTeamPurpose = new System.Windows.Forms.TextBox();
            this.labelTeamPurpose = new System.Windows.Forms.Label();
            this.labelLoginRequiredMessage = new System.Windows.Forms.Label();
            this.buttonBuildTeam = new System.Windows.Forms.Button();
            this.labelTeamBuildHeader = new System.Windows.Forms.Label();
            this.checkBoxNearMe = new System.Windows.Forms.CheckBox();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.comboBoxAgeFrom = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxAgeTo = new System.Windows.Forms.ComboBox();
            this.labelTeamSize = new System.Windows.Forms.Label();
            this.comboBoxTeamSize = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxTeamMember = new System.Windows.Forms.PictureBox();
            this.labelTeamPlayerInfo = new System.Windows.Forms.Label();
            this.buttonRemoveTeamMember = new System.Windows.Forms.Button();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.labelCreatedTeamHeader = new System.Windows.Forms.Label();
            this.labelCreatedTeamTitle = new System.Windows.Forms.Label();
            this.labelCreatedTeamDescription = new System.Windows.Forms.Label();
            this.buttonRemoveTeam = new System.Windows.Forms.Button();
            this.labelTeams = new System.Windows.Forms.Label();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAlbumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabScheduleAPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPostScheduler)).BeginInit();
            this.tabBuildTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamMember)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\". The grader will use it to test yo" +
    "ur app.\r\nType here your own AppID to test it:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabScheduleAPost);
            this.tabControl1.Controls.Add(this.tabBuildTeam);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.selectedPostBox);
            this.tabMain.Controls.Add(this.selectedAlbumCover);
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.listBoxEvents);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.listBoxLikes);
            this.tabMain.Controls.Add(this.listBoxAlbums);
            this.tabMain.Controls.Add(this.listBoxPosts);
            this.tabMain.Controls.Add(this.labelAlbums);
            this.tabMain.Controls.Add(this.labelPosts);
            this.tabMain.Controls.Add(this.textBoxCity);
            this.tabMain.Controls.Add(this.textBoxBirthday);
            this.tabMain.Controls.Add(this.textBoxEmail);
            this.tabMain.Controls.Add(this.labelMyBirthday);
            this.tabMain.Controls.Add(this.labelMyCity);
            this.tabMain.Controls.Add(this.labelMyEmail);
            this.tabMain.Controls.Add(this.pictureBoxProfile);
            this.tabMain.Controls.Add(this.textBoxAppID);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.buttonLogout);
            this.tabMain.Controls.Add(this.buttonLogin);
            this.tabMain.Location = new System.Drawing.Point(4, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1235, 666);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // selectedPostBox
            // 
            this.selectedPostBox.BackColor = System.Drawing.SystemColors.Window;
            this.selectedPostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedPostBox.Location = new System.Drawing.Point(299, 242);
            this.selectedPostBox.Multiline = true;
            this.selectedPostBox.Name = "selectedPostBox";
            this.selectedPostBox.Size = new System.Drawing.Size(171, 148);
            this.selectedPostBox.TabIndex = 60;
            this.selectedPostBox.Text = "Choose a post";
            this.selectedPostBox.Visible = false;
            // 
            // selectedAlbumCover
            // 
            this.selectedAlbumCover.Location = new System.Drawing.Point(299, 475);
            this.selectedAlbumCover.Name = "selectedAlbumCover";
            this.selectedAlbumCover.Size = new System.Drawing.Size(171, 148);
            this.selectedAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedAlbumCover.TabIndex = 72;
            this.selectedAlbumCover.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1040, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "My Events:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 18;
            this.listBoxEvents.Location = new System.Drawing.Point(777, 475);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(171, 148);
            this.listBoxEvents.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "My Likes:";
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.ItemHeight = 18;
            this.listBoxLikes.Location = new System.Drawing.Point(777, 242);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(171, 148);
            this.listBoxLikes.TabIndex = 67;
            this.listBoxLikes.SelectedIndexChanged += new System.EventHandler(this.listBoxLikes_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(21, 475);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(171, 148);
            this.listBoxAlbums.TabIndex = 66;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.myAlbums_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(21, 242);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(171, 148);
            this.listBoxPosts.TabIndex = 65;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Location = new System.Drawing.Point(18, 429);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(85, 18);
            this.labelAlbums.TabIndex = 64;
            this.labelAlbums.Text = "My Albums:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(18, 203);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(75, 18);
            this.labelPosts.TabIndex = 63;
            this.labelPosts.Text = "My Posts:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(1052, 96);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(159, 24);
            this.textBoxCity.TabIndex = 62;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(1052, 54);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(159, 24);
            this.textBoxBirthday.TabIndex = 61;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1052, 14);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(159, 24);
            this.textBoxEmail.TabIndex = 59;
            // 
            // labelMyBirthday
            // 
            this.labelMyBirthday.AutoSize = true;
            this.labelMyBirthday.Location = new System.Drawing.Point(974, 57);
            this.labelMyBirthday.Name = "labelMyBirthday";
            this.labelMyBirthday.Size = new System.Drawing.Size(65, 18);
            this.labelMyBirthday.TabIndex = 58;
            this.labelMyBirthday.Text = "Birthday:";
            // 
            // labelMyCity
            // 
            this.labelMyCity.AutoSize = true;
            this.labelMyCity.Location = new System.Drawing.Point(974, 96);
            this.labelMyCity.Name = "labelMyCity";
            this.labelMyCity.Size = new System.Drawing.Size(37, 18);
            this.labelMyCity.TabIndex = 57;
            this.labelMyCity.Text = "City:";
            // 
            // labelMyEmail
            // 
            this.labelMyEmail.AutoSize = true;
            this.labelMyEmail.Location = new System.Drawing.Point(974, 17);
            this.labelMyEmail.Name = "labelMyEmail";
            this.labelMyEmail.Size = new System.Drawing.Size(49, 18);
            this.labelMyEmail.TabIndex = 56;
            this.labelMyEmail.Text = "Email:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1450160541956417";
            // 
            // tabScheduleAPost
            // 
            this.tabScheduleAPost.Controls.Add(this.buttonEditSelectedSchedulePost);
            this.tabScheduleAPost.Controls.Add(this.buttonAddSchedulePost);
            this.tabScheduleAPost.Controls.Add(this.buttonRemoveScheduledPost);
            this.tabScheduleAPost.Controls.Add(this.buttonPublishedPosts);
            this.tabScheduleAPost.Controls.Add(this.buttonShowAllScheduledPosts);
            this.tabScheduleAPost.Controls.Add(this.buttonViewPostBody);
            this.tabScheduleAPost.Controls.Add(this.buttonUnpublishedPosts);
            this.tabScheduleAPost.Controls.Add(this.dataGridPostScheduler);
            this.tabScheduleAPost.Controls.Add(this.labelWelcomePostScheduling);
            this.tabScheduleAPost.Location = new System.Drawing.Point(4, 27);
            this.tabScheduleAPost.Name = "tabScheduleAPost";
            this.tabScheduleAPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabScheduleAPost.Size = new System.Drawing.Size(1235, 666);
            this.tabScheduleAPost.TabIndex = 1;
            this.tabScheduleAPost.Text = "Schedule a post";
            this.tabScheduleAPost.UseVisualStyleBackColor = true;
            // 
            // buttonEditSelectedSchedulePost
            // 
            this.buttonEditSelectedSchedulePost.Location = new System.Drawing.Point(315, 506);
            this.buttonEditSelectedSchedulePost.Name = "buttonEditSelectedSchedulePost";
            this.buttonEditSelectedSchedulePost.Size = new System.Drawing.Size(228, 33);
            this.buttonEditSelectedSchedulePost.TabIndex = 10;
            this.buttonEditSelectedSchedulePost.Text = "Edit selected scheduled post";
            this.buttonEditSelectedSchedulePost.UseVisualStyleBackColor = true;
            this.buttonEditSelectedSchedulePost.Visible = false;
            // 
            // buttonAddSchedulePost
            // 
            this.buttonAddSchedulePost.Location = new System.Drawing.Point(14, 506);
            this.buttonAddSchedulePost.Name = "buttonAddSchedulePost";
            this.buttonAddSchedulePost.Size = new System.Drawing.Size(202, 33);
            this.buttonAddSchedulePost.TabIndex = 9;
            this.buttonAddSchedulePost.Text = "Schedule a new post";
            this.buttonAddSchedulePost.UseVisualStyleBackColor = true;
            this.buttonAddSchedulePost.Visible = false;
            // 
            // buttonRemoveScheduledPost
            // 
            this.buttonRemoveScheduledPost.Location = new System.Drawing.Point(975, 506);
            this.buttonRemoveScheduledPost.Name = "buttonRemoveScheduledPost";
            this.buttonRemoveScheduledPost.Size = new System.Drawing.Size(242, 33);
            this.buttonRemoveScheduledPost.TabIndex = 8;
            this.buttonRemoveScheduledPost.Text = "Remove selected post";
            this.buttonRemoveScheduledPost.UseVisualStyleBackColor = true;
            this.buttonRemoveScheduledPost.Visible = false;
            // 
            // buttonPublishedPosts
            // 
            this.buttonPublishedPosts.Location = new System.Drawing.Point(233, 86);
            this.buttonPublishedPosts.Name = "buttonPublishedPosts";
            this.buttonPublishedPosts.Size = new System.Drawing.Size(191, 34);
            this.buttonPublishedPosts.TabIndex = 7;
            this.buttonPublishedPosts.Text = "Show published posts";
            this.buttonPublishedPosts.UseVisualStyleBackColor = true;
            this.buttonPublishedPosts.Visible = false;
            // 
            // buttonShowAllScheduledPosts
            // 
            this.buttonShowAllScheduledPosts.Location = new System.Drawing.Point(14, 86);
            this.buttonShowAllScheduledPosts.Name = "buttonShowAllScheduledPosts";
            this.buttonShowAllScheduledPosts.Size = new System.Drawing.Size(191, 34);
            this.buttonShowAllScheduledPosts.TabIndex = 6;
            this.buttonShowAllScheduledPosts.Text = "Show all posts";
            this.buttonShowAllScheduledPosts.UseVisualStyleBackColor = true;
            this.buttonShowAllScheduledPosts.Visible = false;
            // 
            // buttonViewPostBody
            // 
            this.buttonViewPostBody.Location = new System.Drawing.Point(645, 506);
            this.buttonViewPostBody.Name = "buttonViewPostBody";
            this.buttonViewPostBody.Size = new System.Drawing.Size(230, 33);
            this.buttonViewPostBody.TabIndex = 5;
            this.buttonViewPostBody.Text = "View post body";
            this.buttonViewPostBody.UseVisualStyleBackColor = true;
            this.buttonViewPostBody.Visible = false;
            // 
            // buttonUnpublishedPosts
            // 
            this.buttonUnpublishedPosts.Location = new System.Drawing.Point(451, 86);
            this.buttonUnpublishedPosts.Name = "buttonUnpublishedPosts";
            this.buttonUnpublishedPosts.Size = new System.Drawing.Size(191, 34);
            this.buttonUnpublishedPosts.TabIndex = 4;
            this.buttonUnpublishedPosts.Text = "Show unpublished posts";
            this.buttonUnpublishedPosts.UseVisualStyleBackColor = true;
            this.buttonUnpublishedPosts.Visible = false;
            // 
            // dataGridPostScheduler
            // 
            this.dataGridPostScheduler.AllowUserToAddRows = false;
            this.dataGridPostScheduler.AllowUserToDeleteRows = false;
            this.dataGridPostScheduler.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPostScheduler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPostScheduler.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridPostScheduler.ColumnHeadersHeight = 58;
            this.dataGridPostScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPostScheduler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postId,
            this.postBody,
            this.uploadDate,
            this.postPrivacyLevel,
            this.postStatus});
            this.dataGridPostScheduler.Location = new System.Drawing.Point(14, 142);
            this.dataGridPostScheduler.MultiSelect = false;
            this.dataGridPostScheduler.Name = "dataGridPostScheduler";
            this.dataGridPostScheduler.ReadOnly = true;
            this.dataGridPostScheduler.ShowEditingIcon = false;
            this.dataGridPostScheduler.Size = new System.Drawing.Size(1203, 326);
            this.dataGridPostScheduler.TabIndex = 0;
            // 
            // postId
            // 
            this.postId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postId.HeaderText = "Post ID";
            this.postId.MinimumWidth = 20;
            this.postId.Name = "postId";
            this.postId.ReadOnly = true;
            this.postId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // postBody
            // 
            this.postBody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postBody.HeaderText = "Post Body";
            this.postBody.MinimumWidth = 20;
            this.postBody.Name = "postBody";
            this.postBody.ReadOnly = true;
            this.postBody.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uploadDate
            // 
            this.uploadDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uploadDate.HeaderText = "Upload Date";
            this.uploadDate.MinimumWidth = 20;
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.ReadOnly = true;
            this.uploadDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // postPrivacyLevel
            // 
            this.postPrivacyLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postPrivacyLevel.HeaderText = "Privacy Level";
            this.postPrivacyLevel.MinimumWidth = 20;
            this.postPrivacyLevel.Name = "postPrivacyLevel";
            this.postPrivacyLevel.ReadOnly = true;
            this.postPrivacyLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // postStatus
            // 
            this.postStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postStatus.HeaderText = "Post Status";
            this.postStatus.MinimumWidth = 20;
            this.postStatus.Name = "postStatus";
            this.postStatus.ReadOnly = true;
            this.postStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelWelcomePostScheduling
            // 
            this.labelWelcomePostScheduling.AutoSize = true;
            this.labelWelcomePostScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomePostScheduling.Location = new System.Drawing.Point(8, 18);
            this.labelWelcomePostScheduling.Name = "labelWelcomePostScheduling";
            this.labelWelcomePostScheduling.Size = new System.Drawing.Size(416, 31);
            this.labelWelcomePostScheduling.TabIndex = 3;
            this.labelWelcomePostScheduling.Text = "Please login to perform actions";
            // 
            // tabBuildTeam
            // 
            this.tabBuildTeam.Controls.Add(this.splitContainer1);
            this.tabBuildTeam.Location = new System.Drawing.Point(4, 27);
            this.tabBuildTeam.Name = "tabBuildTeam";
            this.tabBuildTeam.Size = new System.Drawing.Size(1235, 666);
            this.tabBuildTeam.TabIndex = 2;
            this.tabBuildTeam.Text = "Build Team";
            this.tabBuildTeam.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTeamPurpose);
            this.splitContainer1.Panel1.Controls.Add(this.labelTeamPurpose);
            this.splitContainer1.Panel1.Controls.Add(this.labelLoginRequiredMessage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBuildTeam);
            this.splitContainer1.Panel1.Controls.Add(this.labelTeamBuildHeader);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxNearMe);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTeamName);
            this.splitContainer1.Panel1.Controls.Add(this.labelAgeRange);
            this.splitContainer1.Panel1.Controls.Add(this.labelTeamName);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxAgeFrom);
            this.splitContainer1.Panel1.Controls.Add(this.labelGender);
            this.splitContainer1.Panel1.Controls.Add(this.labelTo);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxGender);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxAgeTo);
            this.splitContainer1.Panel1.Controls.Add(this.labelTeamSize);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTeamSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1235, 666);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 13;
            // 
            // textBoxTeamPurpose
            // 
            this.textBoxTeamPurpose.Enabled = false;
            this.textBoxTeamPurpose.Location = new System.Drawing.Point(133, 170);
            this.textBoxTeamPurpose.Name = "textBoxTeamPurpose";
            this.textBoxTeamPurpose.Size = new System.Drawing.Size(184, 24);
            this.textBoxTeamPurpose.TabIndex = 4;
            this.textBoxTeamPurpose.Visible = false;
            // 
            // labelTeamPurpose
            // 
            this.labelTeamPurpose.AutoSize = true;
            this.labelTeamPurpose.Enabled = false;
            this.labelTeamPurpose.Location = new System.Drawing.Point(19, 173);
            this.labelTeamPurpose.Name = "labelTeamPurpose";
            this.labelTeamPurpose.Size = new System.Drawing.Size(108, 18);
            this.labelTeamPurpose.TabIndex = 3;
            this.labelTeamPurpose.Text = "Team purpose:";
            this.labelTeamPurpose.Visible = false;
            // 
            // labelLoginRequiredMessage
            // 
            this.labelLoginRequiredMessage.AutoSize = true;
            this.labelLoginRequiredMessage.BackColor = System.Drawing.Color.White;
            this.labelLoginRequiredMessage.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelLoginRequiredMessage.Location = new System.Drawing.Point(60, 85);
            this.labelLoginRequiredMessage.Name = "labelLoginRequiredMessage";
            this.labelLoginRequiredMessage.Size = new System.Drawing.Size(239, 27);
            this.labelLoginRequiredMessage.TabIndex = 15;
            this.labelLoginRequiredMessage.Text = "Please login to perform actions";
            // 
            // buttonBuildTeam
            // 
            this.buttonBuildTeam.Enabled = false;
            this.buttonBuildTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuildTeam.Location = new System.Drawing.Point(22, 382);
            this.buttonBuildTeam.Name = "buttonBuildTeam";
            this.buttonBuildTeam.Size = new System.Drawing.Size(119, 48);
            this.buttonBuildTeam.TabIndex = 14;
            this.buttonBuildTeam.Text = "Build Team!";
            this.buttonBuildTeam.UseVisualStyleBackColor = true;
            this.buttonBuildTeam.Visible = false;
            this.buttonBuildTeam.Click += new System.EventHandler(this.buttonBuildTeam_Click);
            // 
            // labelTeamBuildHeader
            // 
            this.labelTeamBuildHeader.AutoSize = true;
            this.labelTeamBuildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTeamBuildHeader.Enabled = false;
            this.labelTeamBuildHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamBuildHeader.Location = new System.Drawing.Point(0, 0);
            this.labelTeamBuildHeader.Name = "labelTeamBuildHeader";
            this.labelTeamBuildHeader.Padding = new System.Windows.Forms.Padding(15, 40, 0, 40);
            this.labelTeamBuildHeader.Size = new System.Drawing.Size(141, 107);
            this.labelTeamBuildHeader.TabIndex = 0;
            this.labelTeamBuildHeader.Text = "Build Your Team";
            this.labelTeamBuildHeader.Visible = false;
            // 
            // checkBoxNearMe
            // 
            this.checkBoxNearMe.AutoSize = true;
            this.checkBoxNearMe.Enabled = false;
            this.checkBoxNearMe.Location = new System.Drawing.Point(22, 344);
            this.checkBoxNearMe.Name = "checkBoxNearMe";
            this.checkBoxNearMe.Size = new System.Drawing.Size(84, 22);
            this.checkBoxNearMe.TabIndex = 13;
            this.checkBoxNearMe.Text = "Near me";
            this.checkBoxNearMe.UseVisualStyleBackColor = true;
            this.checkBoxNearMe.Visible = false;
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Enabled = false;
            this.textBoxTeamName.Location = new System.Drawing.Point(115, 129);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(184, 24);
            this.textBoxTeamName.TabIndex = 2;
            this.textBoxTeamName.Visible = false;
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Enabled = false;
            this.labelAgeRange.Location = new System.Drawing.Point(19, 256);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(78, 18);
            this.labelAgeRange.TabIndex = 7;
            this.labelAgeRange.Text = "Age range:";
            this.labelAgeRange.Visible = false;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Enabled = false;
            this.labelTeamName.Location = new System.Drawing.Point(18, 132);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(91, 18);
            this.labelTeamName.TabIndex = 1;
            this.labelTeamName.Text = "Team name:";
            this.labelTeamName.Visible = false;
            // 
            // comboBoxAgeFrom
            // 
            this.comboBoxAgeFrom.Enabled = false;
            this.comboBoxAgeFrom.FormattingEnabled = true;
            this.comboBoxAgeFrom.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBoxAgeFrom.Location = new System.Drawing.Point(103, 253);
            this.comboBoxAgeFrom.Name = "comboBoxAgeFrom";
            this.comboBoxAgeFrom.Size = new System.Drawing.Size(49, 26);
            this.comboBoxAgeFrom.TabIndex = 8;
            this.comboBoxAgeFrom.Visible = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Enabled = false;
            this.labelGender.Location = new System.Drawing.Point(19, 295);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(122, 18);
            this.labelGender.TabIndex = 11;
            this.labelGender.Text = "Preferred gender:";
            this.labelGender.Visible = false;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Enabled = false;
            this.labelTo.Location = new System.Drawing.Point(158, 256);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(13, 18);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "-";
            this.labelTo.Visible = false;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxGender.Enabled = false;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "All"});
            this.comboBoxGender.Location = new System.Drawing.Point(147, 292);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(72, 26);
            this.comboBoxGender.TabIndex = 12;
            this.comboBoxGender.Visible = false;
            // 
            // comboBoxAgeTo
            // 
            this.comboBoxAgeTo.Enabled = false;
            this.comboBoxAgeTo.FormattingEnabled = true;
            this.comboBoxAgeTo.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBoxAgeTo.Location = new System.Drawing.Point(177, 253);
            this.comboBoxAgeTo.Name = "comboBoxAgeTo";
            this.comboBoxAgeTo.Size = new System.Drawing.Size(49, 26);
            this.comboBoxAgeTo.TabIndex = 10;
            this.comboBoxAgeTo.Visible = false;
            // 
            // labelTeamSize
            // 
            this.labelTeamSize.AutoSize = true;
            this.labelTeamSize.Enabled = false;
            this.labelTeamSize.Location = new System.Drawing.Point(19, 214);
            this.labelTeamSize.Name = "labelTeamSize";
            this.labelTeamSize.Size = new System.Drawing.Size(81, 18);
            this.labelTeamSize.TabIndex = 5;
            this.labelTeamSize.Text = "Team size:";
            this.labelTeamSize.Visible = false;
            // 
            // comboBoxTeamSize
            // 
            this.comboBoxTeamSize.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxTeamSize.Enabled = false;
            this.comboBoxTeamSize.FormattingEnabled = true;
            this.comboBoxTeamSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxTeamSize.Location = new System.Drawing.Point(103, 211);
            this.comboBoxTeamSize.Name = "comboBoxTeamSize";
            this.comboBoxTeamSize.Size = new System.Drawing.Size(49, 26);
            this.comboBoxTeamSize.TabIndex = 6;
            this.comboBoxTeamSize.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxTeamMember);
            this.splitContainer2.Panel1.Controls.Add(this.labelTeamPlayerInfo);
            this.splitContainer2.Panel1.Controls.Add(this.buttonRemoveTeamMember);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxTeamMembers);
            this.splitContainer2.Panel1.Controls.Add(this.labelCreatedTeamHeader);
            this.splitContainer2.Panel1.Controls.Add(this.labelCreatedTeamTitle);
            this.splitContainer2.Panel1.Controls.Add(this.labelCreatedTeamDescription);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonRemoveTeam);
            this.splitContainer2.Panel2.Controls.Add(this.labelTeams);
            this.splitContainer2.Panel2.Controls.Add(this.listBoxTeams);
            this.splitContainer2.Size = new System.Drawing.Size(821, 666);
            this.splitContainer2.SplitterDistance = 580;
            this.splitContainer2.TabIndex = 4;
            // 
            // pictureBoxTeamMember
            // 
            this.pictureBoxTeamMember.Enabled = false;
            this.pictureBoxTeamMember.Location = new System.Drawing.Point(275, 280);
            this.pictureBoxTeamMember.Name = "pictureBoxTeamMember";
            this.pictureBoxTeamMember.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxTeamMember.TabIndex = 22;
            this.pictureBoxTeamMember.TabStop = false;
            this.pictureBoxTeamMember.Visible = false;
            // 
            // labelTeamPlayerInfo
            // 
            this.labelTeamPlayerInfo.AutoSize = true;
            this.labelTeamPlayerInfo.Enabled = false;
            this.labelTeamPlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamPlayerInfo.Location = new System.Drawing.Point(272, 382);
            this.labelTeamPlayerInfo.Name = "labelTeamPlayerInfo";
            this.labelTeamPlayerInfo.Size = new System.Drawing.Size(145, 18);
            this.labelTeamPlayerInfo.TabIndex = 5;
            this.labelTeamPlayerInfo.Text = "Player Information";
            this.labelTeamPlayerInfo.Visible = false;
            // 
            // buttonRemoveTeamMember
            // 
            this.buttonRemoveTeamMember.Enabled = false;
            this.buttonRemoveTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveTeamMember.Location = new System.Drawing.Point(46, 544);
            this.buttonRemoveTeamMember.Name = "buttonRemoveTeamMember";
            this.buttonRemoveTeamMember.Size = new System.Drawing.Size(148, 48);
            this.buttonRemoveTeamMember.TabIndex = 4;
            this.buttonRemoveTeamMember.Text = "Remove Team Member";
            this.buttonRemoveTeamMember.UseVisualStyleBackColor = true;
            this.buttonRemoveTeamMember.Visible = false;
            this.buttonRemoveTeamMember.Click += new System.EventHandler(this.buttonRemoveTeamMember_Click);
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.Enabled = false;
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 18;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(46, 280);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(148, 238);
            this.listBoxTeamMembers.TabIndex = 3;
            this.listBoxTeamMembers.Visible = false;
            this.listBoxTeamMembers.SelectedIndexChanged += new System.EventHandler(this.listBoxTeamMembers_SelectedIndexChanged);
            // 
            // labelCreatedTeamHeader
            // 
            this.labelCreatedTeamHeader.AutoSize = true;
            this.labelCreatedTeamHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCreatedTeamHeader.Enabled = false;
            this.labelCreatedTeamHeader.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedTeamHeader.Location = new System.Drawing.Point(0, 0);
            this.labelCreatedTeamHeader.Name = "labelCreatedTeamHeader";
            this.labelCreatedTeamHeader.Size = new System.Drawing.Size(137, 31);
            this.labelCreatedTeamHeader.TabIndex = 0;
            this.labelCreatedTeamHeader.Text = "Your Team:";
            this.labelCreatedTeamHeader.Visible = false;
            // 
            // labelCreatedTeamTitle
            // 
            this.labelCreatedTeamTitle.AutoSize = true;
            this.labelCreatedTeamTitle.Enabled = false;
            this.labelCreatedTeamTitle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedTeamTitle.Location = new System.Drawing.Point(7, 85);
            this.labelCreatedTeamTitle.Name = "labelCreatedTeamTitle";
            this.labelCreatedTeamTitle.Size = new System.Drawing.Size(100, 25);
            this.labelCreatedTeamTitle.TabIndex = 1;
            this.labelCreatedTeamTitle.Text = "Team Title";
            this.labelCreatedTeamTitle.Visible = false;
            // 
            // labelCreatedTeamDescription
            // 
            this.labelCreatedTeamDescription.AutoSize = true;
            this.labelCreatedTeamDescription.Enabled = false;
            this.labelCreatedTeamDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedTeamDescription.Location = new System.Drawing.Point(9, 119);
            this.labelCreatedTeamDescription.Name = "labelCreatedTeamDescription";
            this.labelCreatedTeamDescription.Size = new System.Drawing.Size(130, 18);
            this.labelCreatedTeamDescription.TabIndex = 2;
            this.labelCreatedTeamDescription.Text = "Team Description";
            this.labelCreatedTeamDescription.Visible = false;
            // 
            // buttonRemoveTeam
            // 
            this.buttonRemoveTeam.Enabled = false;
            this.buttonRemoveTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveTeam.Location = new System.Drawing.Point(62, 199);
            this.buttonRemoveTeam.Name = "buttonRemoveTeam";
            this.buttonRemoveTeam.Size = new System.Drawing.Size(120, 48);
            this.buttonRemoveTeam.TabIndex = 2;
            this.buttonRemoveTeam.Text = "Remove Team";
            this.buttonRemoveTeam.UseVisualStyleBackColor = true;
            this.buttonRemoveTeam.Visible = false;
            this.buttonRemoveTeam.Click += new System.EventHandler(this.buttonRemoveTeam_Click);
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Enabled = false;
            this.labelTeams.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTeams.Location = new System.Drawing.Point(57, 41);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(96, 25);
            this.labelTeams.TabIndex = 0;
            this.labelTeams.Text = "All teams:";
            this.labelTeams.Visible = false;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.Enabled = false;
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.ItemHeight = 18;
            this.listBoxTeams.Location = new System.Drawing.Point(62, 85);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(120, 94);
            this.listBoxTeams.TabIndex = 1;
            this.listBoxTeams.Visible = false;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Facebook App";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAlbumCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabScheduleAPost.ResumeLayout(false);
            this.tabScheduleAPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPostScheduler)).EndInit();
            this.tabBuildTeam.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamMember)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabMain;
		private System.Windows.Forms.TabPage tabScheduleAPost;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMyBirthday;
        private System.Windows.Forms.Label labelMyCity;
        private System.Windows.Forms.Label labelMyEmail;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLikes;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox selectedAlbumCover;
        private System.Windows.Forms.TextBox selectedPostBox;
        private System.Windows.Forms.TabPage tabBuildTeam;
        private System.Windows.Forms.Button buttonEditSelectedSchedulePost;
        private System.Windows.Forms.Button buttonAddSchedulePost;
        private System.Windows.Forms.Button buttonRemoveScheduledPost;
        private System.Windows.Forms.Button buttonPublishedPosts;
        private System.Windows.Forms.Button buttonShowAllScheduledPosts;
        private System.Windows.Forms.Button buttonViewPostBody;
        private System.Windows.Forms.Button buttonUnpublishedPosts;
        private System.Windows.Forms.DataGridView dataGridPostScheduler;
        private System.Windows.Forms.DataGridViewTextBoxColumn postId;
        private System.Windows.Forms.DataGridViewTextBoxColumn postBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn postPrivacyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn postStatus;
        private System.Windows.Forms.Label labelWelcomePostScheduling;
        private System.Windows.Forms.ComboBox comboBoxAgeFrom;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.ComboBox comboBoxAgeTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.CheckBox checkBoxNearMe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelTeamBuildHeader;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelTeamSize;
        private System.Windows.Forms.ComboBox comboBoxTeamSize;
        private System.Windows.Forms.Button buttonBuildTeam;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Label labelCreatedTeamDescription;
        private System.Windows.Forms.Label labelCreatedTeamHeader;
        private System.Windows.Forms.Label labelCreatedTeamTitle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.Label labelTeamPlayerInfo;
        private System.Windows.Forms.Label labelLoginRequiredMessage;
        private System.Windows.Forms.TextBox textBoxTeamPurpose;
        private System.Windows.Forms.Label labelTeamPurpose;
        private System.Windows.Forms.Button buttonRemoveTeamMember;
        private System.Windows.Forms.PictureBox pictureBoxTeamMember;
        private System.Windows.Forms.Button buttonRemoveTeam;
    }
}

