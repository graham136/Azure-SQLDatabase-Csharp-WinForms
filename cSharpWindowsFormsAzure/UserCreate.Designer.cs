namespace cSharpWindowsFormsAzure
{
    partial class UserCreate
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
            this.buttonCreateUserExit = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateUserExit
            // 
            this.buttonCreateUserExit.Location = new System.Drawing.Point(13, 98);
            this.buttonCreateUserExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateUserExit.Name = "buttonCreateUserExit";
            this.buttonCreateUserExit.Size = new System.Drawing.Size(401, 19);
            this.buttonCreateUserExit.TabIndex = 9;
            this.buttonCreateUserExit.Text = "Exit";
            this.buttonCreateUserExit.UseVisualStyleBackColor = true;
            this.buttonCreateUserExit.Click += new System.EventHandler(this.buttonCreateUserExit_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(87, 51);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(327, 20);
            this.textBoxUserPassword.TabIndex = 8;
           // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(87, 8);
            this.textboxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(327, 20);
            this.textboxUserName.TabIndex = 7;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(10, 51);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(81, 13);
            this.labelUserPassword.TabIndex = 6;
            this.labelUserPassword.Text = "User Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(11, 9);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "User Name:";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(14, 75);
            this.buttonCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(401, 19);
            this.buttonCreateUser.TabIndex = 10;
            this.buttonCreateUser.Text = "Create";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 134);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.buttonCreateUserExit);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "UserCreate";
            this.Text = "UserCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateUserExit;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonCreateUser;
    }
}