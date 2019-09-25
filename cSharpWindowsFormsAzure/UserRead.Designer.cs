namespace cSharpWindowsFormsAzure
{
    partial class UserRead
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.buttonReadUserExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(13, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(83, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(12, 65);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(107, 17);
            this.labelUserPassword.TabIndex = 1;
            this.labelUserPassword.Text = "User Password:";
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(115, 12);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(435, 22);
            this.textboxUserName.TabIndex = 2;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(115, 65);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(435, 22);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // buttonReadUserExit
            // 
            this.buttonReadUserExit.Location = new System.Drawing.Point(15, 102);
            this.buttonReadUserExit.Name = "buttonReadUserExit";
            this.buttonReadUserExit.Size = new System.Drawing.Size(535, 23);
            this.buttonReadUserExit.TabIndex = 4;
            this.buttonReadUserExit.Text = "Exit";
            this.buttonReadUserExit.UseVisualStyleBackColor = true;
            this.buttonReadUserExit.Click += new System.EventHandler(this.buttonReadUserExit_Click);
            // 
            // UserRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 137);
            this.Controls.Add(this.buttonReadUserExit);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "UserRead";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserRead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonReadUserExit;
    }
}