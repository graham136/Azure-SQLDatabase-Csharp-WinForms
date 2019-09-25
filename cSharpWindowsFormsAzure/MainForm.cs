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
    
    public partial class MainForm : Form
    {
        public BindingSource usersBindingSource = new BindingSource();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Setup Connection String
                // Please Change this to the required 
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "datasource.database.windows.net";
                builder.UserID = "user";
                builder.Password = "password";
                builder.InitialCatalog = "initialcatalog";

                // Setup Sql String

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ID as id, name as UserName, password Password FROM users");
                
                String sql = sb.ToString();


                // Set up the DataGridView.
                usersGridView.Dock = DockStyle.Fill;

                // Automatically generate the DataGridView columns.
                usersGridView.AutoGenerateColumns = true;

                // Set up the data source.
                usersBindingSource.DataSource = GetData(sql, builder.ConnectionString);
                usersGridView.DataSource = usersBindingSource;

                // Automatically resize the visible rows.
                usersGridView.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Automatically resize the column headers
                usersGridView.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Set the DataGridView control's border.
                usersGridView.BorderStyle = BorderStyle.Fixed3D;

                // Put the cells in edit mode when user enters them.
                usersGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

                // Set the selection type to row
                usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (SqlException dberror)
            {
                MessageBox.Show(dberror.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private static DataTable GetData(string sqlCommand,string connectionString)
        {
            SqlConnection dbconnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, dbconnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            dbconnection.Close();

            return table;
        }

        private void readUser_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count>0)
            {
                string Tempvalue = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(Tempvalue, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                int selectedRow = Int32.Parse(usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedRow > -1)
                {
                    UserRead userRead = new UserRead(selectedRow);
                    userRead.Show();
                }
            }
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            UserCreate userCreate = new UserCreate(this);
            userCreate.Show();
        }

        public void ReloadData()
        {


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "coll8agent.database.windows.net";
            builder.UserID = "bbdAdmin";
            builder.Password = "BBDisgreat123";
            builder.InitialCatalog = "coll8Agent";

            // Setup Sql String

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ID as id, name as UserName, password Password FROM users");
           
            String sqlCommand = sb.ToString();

            usersBindingSource.DataSource = GetData(sqlCommand, builder.ConnectionString);
            usersGridView.DataSource = usersBindingSource;

        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count > 0)
            {
                string Tempvalue = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(Tempvalue, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                int selectedRow = Int32.Parse(usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedRow > -1)
                {
                    UserUpdate userUpdate = new UserUpdate(selectedRow,this);
                    userUpdate.Show();
                }
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count > 0)
            {
                string Tempvalue = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(Tempvalue, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                int selectedRow = Int32.Parse(usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedRow > -1)
                {
                    int userId = selectedRow;
                    // Setup Connection String
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "coll8agent.database.windows.net";
                    builder.UserID = "bbdAdmin";
                    builder.Password = "BBDisgreat123";
                    builder.InitialCatalog = "coll8Agent";

                    // Setup Sql String

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM users WHERE(id = @tempId)");
                  
                    String sqlCommand = sb.ToString();
                    MessageBox.Show(sqlCommand, "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlConnection dbconnection = new SqlConnection(builder.ConnectionString);

                    dbconnection.Open();

                    SqlCommand command = new SqlCommand(sqlCommand, dbconnection);
                    command.Parameters.AddWithValue("@tempId", userId);

                    command.ExecuteNonQuery();
                    dbconnection.Close();
                    this.ReloadData();
                }
            }
        }       
    }
}
