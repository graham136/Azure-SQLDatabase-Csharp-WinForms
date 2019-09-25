namespace cSharpWindowsFormsAzure
{
    partial class UserUpdate
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
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonUpdateUserExit = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(14, 75);
            this.buttonUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(401, 19);
            this.buttonUpdateUser.TabIndex = 16;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonUpdateUserExit
            // 
            this.buttonUpdateUserExit.Location = new System.Drawing.Point(13, 98);
            this.buttonUpdateUserExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateUserExit.Name = "buttonUpdateUserExit";
            this.buttonUpdateUserExit.Size = new System.Drawing.Size(402, 19);
            this.buttonUpdateUserExit.TabIndex = 15;
            this.buttonUpdateUserExit.Text = "Exit";
            this.buttonUpdateUserExit.UseVisualStyleBackColor = true;
            this.buttonUpdateUserExit.Click += new System.EventHandler(this.buttonUpdateUserExit_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(87, 51);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(327, 20);
            this.textBoxUserPassword.TabIndex = 14;
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(87, 8);
            this.textboxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(327, 20);
            this.textboxUserName.TabIndex = 13;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(10, 51);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(81, 13);
            this.labelUserPassword.TabIndex = 12;
            this.labelUserPassword.Text = "User Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(11, 9);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "User Name:";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 138);
            this.Controls.Add(this.buttonUpdateUser);
            this.Controls.Add(this.buttonUpdateUserExit);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            this.Load += new System.EventHandler(this.UserUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonUpdateUserExit;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserName;
    }
}