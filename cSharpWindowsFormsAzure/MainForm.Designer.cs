namespace cSharpWindowsFormsAzure
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.readUser = new System.Windows.Forms.Button();
            this.createUser = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteUser);
            this.groupBox1.Controls.Add(this.updateUser);
            this.groupBox1.Controls.Add(this.readUser);
            this.groupBox1.Controls.Add(this.createUser);
            this.groupBox1.Controls.Add(this.usersGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1077, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(251, 474);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 4;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(169, 474);
            this.updateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(75, 23);
            this.updateUser.TabIndex = 3;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // readUser
            // 
            this.readUser.Location = new System.Drawing.Point(88, 474);
            this.readUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readUser.Name = "readUser";
            this.readUser.Size = new System.Drawing.Size(75, 23);
            this.readUser.TabIndex = 2;
            this.readUser.Text = "Read";
            this.readUser.UseVisualStyleBackColor = true;
            this.readUser.Click += new System.EventHandler(this.readUser_Click);
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(7, 474);
            this.createUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(75, 23);
            this.createUser.TabIndex = 1;
            this.createUser.Text = "Create";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(7, 22);
            this.usersGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowHeadersWidth = 51;
            this.usersGridView.RowTemplate.Height = 24;
            this.usersGridView.Size = new System.Drawing.Size(1065, 446);
            this.usersGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 528);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "CSharpWinformsAzure";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Button readUser;
        private System.Windows.Forms.Button createUser;
        public System.Windows.Forms.DataGridView usersGridView;
    }
}

