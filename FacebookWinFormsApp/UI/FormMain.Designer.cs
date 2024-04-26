﻿namespace BasicFacebookFeatures
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectedAlbumCover = new System.Windows.Forms.PictureBox();
            this.selectedPostBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAlbumCover)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectedPostBox);
            this.tabPage1.Controls.Add(this.selectedAlbumCover);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxLikes);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.labelAlbums);
            this.tabPage1.Controls.Add(this.labelPosts);
            this.tabPage1.Controls.Add(this.textBoxCity);
            this.tabPage1.Controls.Add(this.textBoxBirthday);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.labelMyBirthday);
            this.tabPage1.Controls.Add(this.labelMyCity);
            this.tabPage1.Controls.Add(this.labelMyEmail);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAlbumCover)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
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
    }
}

