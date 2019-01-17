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

    public partial class Login : MaterialForm
    {
        private string conn;
        private SqlConnection connect;

        public Login()
        {
            InitializeComponent();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Establish database connection
                db_connection();

                string EncryptedPassword = Eramake.eCryptography.Encrypt(txtInputPassword.Text);

                //Check to see if Username and Password combination works
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT COUNT (*) FROM dbo.GAMEUSERS WHERE Username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @Pass COLLATE SQL_Latin1_General_CP1_CS_AS";
                cmd.Parameters.AddWithValue("@Username", txtInputUsername.Text);
                cmd.Parameters.AddWithValue("@Pass", EncryptedPassword);
                cmd.Connection = connect;

                int result = (int)cmd.ExecuteScalar();

                //Close connection
                connect.Close();

                //If not found then
                if (result == 0)
                {
                    //Tell user there is invalid credentials
                    MessageBox.Show("Invalid Crententials Entered");
                }
                else
                {
                    //establish connection
                    db_connection();

                    //Get users admin value
                    cmd = new SqlCommand();
                    cmd.CommandText = "SELECT isAdmin FROM dbo.GAMEUSERS WHERE Username = @Username";
                    cmd.Parameters.AddWithValue("@Username", txtInputUsername.Text);
                    cmd.Connection = connect;
                    result = (int)cmd.ExecuteScalar();

                    //Close connection
                    connect.Close();

                    //Create user object
                    User currentUserLogin = new User(txtInputUsername.Text, result);

                    //Open menu form and carry user object over
                    this.Hide();
                    var MenuWindow = new VirusGame();
                    MenuWindow.currentUserMenu = currentUserLogin;
                    MenuWindow.Closed += (s, args) => this.Close();
                    MenuWindow.Show();
                }
            }
            catch
            {
                //Inform user there was an issue connecting to the database
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("Issue connecting to DataBase", "Connection Issue",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            //Close application
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Switch to register form
            this.Hide();
            var RegisterWindow = new RegisterUser();
            RegisterWindow.Closed += (s, args) => this.Close();
            RegisterWindow.Show();
        }
    }
}
