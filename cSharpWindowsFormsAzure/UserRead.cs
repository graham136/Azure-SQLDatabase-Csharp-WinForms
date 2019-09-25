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
    public partial class UserRead : Form
    {

        int userId;
        public UserRead(int id)
        {
            InitializeComponent();
            userId = id;
            
        }

        /// <summary>
        /// Method that executes on the Exit button click
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void buttonReadUserExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that executes on the form load
        /// </summary>
        /// <param name="sender"> button click event</param>
        /// <param name="e"> button click arguments</param>
        private void UserRead_Load(object sender, EventArgs e)
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
    }
}
