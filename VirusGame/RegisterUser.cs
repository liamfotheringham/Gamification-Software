using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MaterialSkin.Controls;
namespace VirusGame
{
    public partial class RegisterUser : MaterialForm
    {
        private string conn;
        private SqlConnection connect;

        //Established the Database Connection 
        private void db_connection()
        {
            try
            {
                //Connection with database
                conn = "Data Source = xxxx; Initial Catalog = xxxx; USer ID = xxxx; Password = xxxx";
                connect = new SqlConnection(conn);
                //Establish connection
                connect.Open();
            }
            catch (SqlException e)
            {
                //Throw an exception
                throw;
            }
        }

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Register(string Username, string Password)
        {
            try
            {

                //Establish database connection
                db_connection();

                //Encrypt password
                string EncryptedPassword = Eramake.eCryptography.Encrypt(Password);

                //Check to see if Username and Password combination works
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT COUNT (*) FROM dbo.GAMEUSERS WHERE Username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS";
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Connection = connect;

                int result = (int)cmd.ExecuteScalar();

                //If question ID already exists then tell user
                if (result == 1)
                {
                    MessageBox.Show("This Username already exists", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Otherwise, insert question into the database
                else
                {
                    cmd = new SqlCommand("INSERT INTO dbo.GAMEUSERS (Username, Password, isAdmin) VALUES (@Username, @Password, 0)", connect);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Registered User");
                    }

                    //Switch to login form
                    this.Hide();
                    var LoginWindow = new Login();
                    LoginWindow.Closed += (s, args) => this.Close();
                    LoginWindow.Show();
                }

                //Close Connection
                connect.Close();

            }
            catch
            {
                //Inform the user an Error has occured
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("An Error has occured", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register(txtUsername.Text, txtPassword.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Switch to login form
            this.Hide();
            var LoginWindow = new Login();
            LoginWindow.Closed += (s, args) => this.Close();
            LoginWindow.Show();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }
    }
}
