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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAlbumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabScheduleAPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPostScheduler)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
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
            this.buttonEditSelectedSchedulePost.Click += new System.EventHandler(this.buttonEditSelectedSchedulePost_Click);
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
            this.buttonAddSchedulePost.Click += new System.EventHandler(this.buttonAddSchedulePost_Click);
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
            this.buttonRemoveScheduledPost.Click += new System.EventHandler(this.buttonRemoveScheduledPost_Click);
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
            this.buttonPublishedPosts.Click += new System.EventHandler(this.buttonPublishedPosts_Click);
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
            this.buttonShowAllScheduledPosts.Click += new System.EventHandler(this.buttonShowAllScheduledPosts_Click);
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
            this.buttonViewPostBody.Click += new System.EventHandler(this.buttonViewPostBody_Click);
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
            this.buttonUnpublishedPosts.Click += new System.EventHandler(this.buttonUnpublishedPosts_Click);
            // 
            // dataGridPostScheduler
            // 
            this.dataGridPostScheduler.AllowUserToAddRows = false;
            this.dataGridPostScheduler.AllowUserToDeleteRows = false;
            this.dataGridPostScheduler.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPostScheduler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
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
            this.dataGridPostScheduler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPostScheduler_CellContentClick);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1235, 666);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}

