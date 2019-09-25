using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpWindowsFormsAzure
{
    public partial class UserUpdate : Form
    {
        int userId;
        MainForm tempMainForm;

        public UserUpdate(int id, MainForm mainForm)
        {
            InitializeComponent();
            userId = id;
            tempMainForm = mainForm;
        }

        /// <summary>
        /// Method that executes on the form load
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void UserUpdate_Load(object sender, EventArgs e)
        {
            // Setup Connection String
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "datasource.database.windows.net";
            builder.UserID = "userId";
            builder.Password = "password";
            builder.InitialCatalog = "initialcatalog";

            // Setup Sql String

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ID as id, name as UserName, password as Password FROM users Where id=@tempid");

            String sqlCommand = sb.ToString();

            MessageBox.Show(sqlCommand, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlConnection dbconnection = new SqlConnection(builder.ConnectionString);

            dbconnection.Open();

            SqlCommand command = new SqlCommand(sqlCommand, dbconnection);
            command.Parameters.AddWithValue("@tempid", userId);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    textboxUserName.Text = reader["UserName"].ToString();
                    textBoxUserPassword.Text = reader["Password"].ToString();
                }
            }

            dbconnection.Close();
        }

        /// <summary>
        /// Method that executes on the Update user button click
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            string tempName = textboxUserName.Text;
            string tempPassword = textBoxUserPassword.Text;

            // Setup Connection String
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "datasource.database.windows.net";
            builder.UserID = "userId";
            builder.Password = "password";
            builder.InitialCatalog = "initialcatalog";

            // Setup Sql String

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE users SET name = @username, password = @userpassword WHERE(id = @tempId)");
            
            String sqlCommand = sb.ToString();
            MessageBox.Show(sqlCommand, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
            SqlConnection dbconnection = new SqlConnection(builder.ConnectionString);

            dbconnection.Open();

            SqlCommand command = new SqlCommand(sqlCommand, dbconnection);
            command.Parameters.AddWithValue("@username", tempName);
            command.Parameters.AddWithValue("@userpassword", tempPassword);
            command.Parameters.AddWithValue("@tempId", userId);

            command.ExecuteNonQuery();
            dbconnection.Close();
            tempMainForm.ReloadData();
            this.Close();
        }

        /// <summary>
        /// Method that executes on the Exit button click
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void buttonUpdateUserExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
