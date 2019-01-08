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
    public partial class Highscores : MaterialForm
    {

        Scores[] Scores = new Scores[10];
        private string conn;
        private SqlConnection connect;
        public User currentUserHighscores;

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

        public Highscores()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Switch to menu form and carry user object over
            this.Hide();
            var MenuWindow = new VirusGame();
            MenuWindow.currentUserMenu = currentUserHighscores;
            MenuWindow.Closed += (s, args) => this.Close();
            MenuWindow.Show();
        }

        private void Highscores_Load(object sender, EventArgs e)
        {
            try
            {
                lblPlaces.Text = "";
                lblUsernames.Text = "";
                lblScores.Text = "";

                //Create Scores objects
                for (int j = 0; j < Scores.Length; j++)
                {
                    //Create object
                    Scores[j] = new Scores();
                }

                int i = 0;

                //Establish database connection
                db_connection();

                //Get all of the selected question attributes
                SqlCommand cmd = new SqlCommand("SELECT * FROM HIGHSCORES ORDER BY Score ASC;", connect);

                //Read values
                SqlDataReader sdr = cmd.ExecuteReader();

                //Whilst reading values, make local varable values to those from columns in selected row
                while (sdr.Read())
                {
                    Scores[i].ScoreID = Int32.Parse(sdr[0].ToString());
                    Scores[i].Username = sdr[1].ToString();
                    Scores[i].Score = Int32.Parse(sdr[2].ToString());
                    i++;
                }

                //close connection
                connect.Close();

                //List for displaying values
                var places = new List<string>();
                var usernames = new List<string>();
                var scores = new List<string>();

                //Add values from scores objects to lists
                for (i = 0; i < 10; i++)
                {
                    places.Add((i + 1).ToString());
                    usernames.Add(Scores[i].Username);
                    scores.Add((Scores[i].Score).ToString());
                }

                //Display lists in labels
                lblPlaces.Text += places.Aggregate((x, y) => x + "\n" + y);
                lblUsernames.Text += usernames.Aggregate((x, y) => x + "\n" + y);
                lblScores.Text += scores.Aggregate((x, y) => x + "\n" + y);

            }
            catch
            {
                //Inform user there was an issue connecting to the database
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("Issue Connecting to DataBase");
            }

        }

        private void lblPlaces_Click(object sender, EventArgs e)
        {

        }
    }
}
