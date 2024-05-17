
namespace BasicFacebookFeatures.UI
{
    partial class FormAddScheduledPost
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
            this.labelPostBody = new System.Windows.Forms.Label();
            this.labelPrivacyLevel = new System.Windows.Forms.Label();
            this.labelDateToPost = new System.Windows.Forms.Label();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPrivacy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelPostBody
            // 
            this.labelPostBody.AutoSize = true;
            this.labelPostBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelPostBody.Location = new System.Drawing.Point(62, 52);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(213, 20);
            this.labelPostBody.TabIndex = 0;
            this.labelPostBody.Text = "Please enter the post body:";
            // 
            // labelPrivacyLevel
            // 
            this.labelPrivacyLevel.AutoSize = true;
            this.labelPrivacyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelPrivacyLevel.Location = new System.Drawing.Point(62, 360);
            this.labelPrivacyLevel.Name = "labelPrivacyLevel";
            this.labelPrivacyLevel.Size = new System.Drawing.Size(244, 20);
            this.labelPrivacyLevel.TabIndex = 1;
            this.labelPrivacyLevel.Text = "Choose who can see your post:";
            // 
            // labelDateToPost
            // 
            this.labelDateToPost.AutoSize = true;
            this.labelDateToPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDateToPost.Location = new System.Drawing.Point(62, 305);
            this.labelDateToPost.Name = "labelDateToPost";
            this.labelDateToPost.Size = new System.Drawing.Size(258, 20);
            this.labelDateToPost.TabIndex = 2;
            this.labelDateToPost.Text = "Choose a date to create the post:";
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(66, 92);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.Size = new System.Drawing.Size(663, 186);
            this.textBoxPostBody.TabIndex = 3;
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonPost.Location = new System.Drawing.Point(653, 399);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(135, 39);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(339, 305);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // comboBoxPrivacy
            // 
            this.comboBoxPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBoxPrivacy.FormattingEnabled = true;
            this.comboBoxPrivacy.Items.AddRange(new object[] {
            "Everyone",
            "My friends",
            "Me"});
            this.comboBoxPrivacy.Location = new System.Drawing.Point(339, 358);
            this.comboBoxPrivacy.Name = "comboBoxPrivacy";
            this.comboBoxPrivacy.Size = new System.Drawing.Size(259, 23);
            this.comboBoxPrivacy.TabIndex = 6;
            // 
            // FormAddScheduledPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPrivacy);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.labelDateToPost);
            this.Controls.Add(this.labelPrivacyLevel);
            this.Controls.Add(this.labelPostBody);
            this.Name = "FormAddScheduledPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddScheduledPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.Label labelPrivacyLevel;
        protected System.Windows.Forms.TextBox textBoxPostBody;
        protected System.Windows.Forms.DateTimePicker dateTimePicker;
        protected System.Windows.Forms.ComboBox comboBoxPrivacy;
        protected System.Windows.Forms.Button buttonPost;
        protected System.Windows.Forms.Label labelDateToPost;
    }
}