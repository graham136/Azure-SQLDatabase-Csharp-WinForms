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
    public partial class UserCreate : Form
    {
        private readonly MainForm tempMainForm;
        public UserCreate(MainForm mainForm)
        {
            InitializeComponent();
            tempMainForm = mainForm;
        }

        /// <summary>
        /// Method that executes on the Exit button click
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void buttonCreateUserExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that executes on the Create User button click
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void buttonCreateUser_Click(object sender, EventArgs e)
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
            sb.Append("INSERT INTO users (name,password) VALUES (@username,@password)");
           
            String sqlCommand = sb.ToString();
            MessageBox.Show(sqlCommand, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlConnection dbconnection = new SqlConnection(builder.ConnectionString);

            dbconnection.Open();

            SqlCommand command = new SqlCommand(sqlCommand, dbconnection);
            command.Parameters.AddWithValue("@username", tempName);
            command.Parameters.AddWithValue("@password", tempPassword);

            command.ExecuteNonQuery();
            dbconnection.Close();
            tempMainForm.ReloadData();
            this.Close();
        }        
    }
}
