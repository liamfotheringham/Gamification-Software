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


    public partial class VirusGame : MaterialForm
    {
        public User currentUserMenu;

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

        public VirusGame()
        {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Establish database connection
                db_connection();

                //Switch to game form and carry user object over
                this.Hide();
                var GameWindow = new MainGame();
                GameWindow.currentUserGame = currentUserMenu;
                GameWindow.Closed += (s, args) => this.Close();
                GameWindow.Show();
            }
            catch
            {
                //Inform user there was a issue connecting to the database
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("Issue Connecting to DataBase");
            }
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            try
            {
                //Establish database connection
                db_connection();

                //Switch to highscores form and carry user object over
                this.Hide();
                var HighscoresWindow = new Highscores();
                HighscoresWindow.currentUserHighscores = currentUserMenu;
                HighscoresWindow.Closed += (s, args) => this.Close();
                HighscoresWindow.Show();
            }
            catch
            {
                //Inform user there was a issue connecting to the database
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("Issue Connecting to DataBase");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Switch to login form and carry user object over
            this.Hide();
            var LoginWindow = new Login();
            LoginWindow.Closed += (s, args) => this.Close();
            LoginWindow.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //If an admin then display admin button
            if (currentUserMenu.isAdmin == 1)
            {
                btnAdmin.Visible = true;
            }
            //If not then don't
            else
            {
                btnAdmin.Visible = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                //Establish database connection
                db_connection();

                //Switch to admin form and carry user object over
                this.Hide();
                var AdminPanelWindow = new Admin();
                AdminPanelWindow.currentUserAdminPanel = currentUserMenu;
                AdminPanelWindow.Closed += (s, args) => this.Close();
                AdminPanelWindow.Show();
            }
            catch
            {
                //Inform user there was a issue connecting to the database
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("Issue Connecting to DataBase");
            }
        }
    }
}
