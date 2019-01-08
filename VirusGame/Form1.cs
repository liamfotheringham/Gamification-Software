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
using System.Collections;
using System.Data.SqlTypes;
using MaterialSkin.Controls;

namespace VirusGame
{
    public partial class MainGame : MaterialForm
    {
        private string conn;
        private SqlConnection connect;

        Scores[] Scores = new Scores[10];
        int numOfQuestions;
        ArrayList QuestionsAL = new ArrayList();
        ArrayList UsedQuestions = new ArrayList();

        int QuestionID;
        int reputation = 50;
        int virus = 50;
        int turnCounter = 1;
        string currentQuestion = "This is a question";
        string Choice1Text = "Yes";
        string Choice2Text = "No";
        string Message = "";
        int Choice1Virus;
        int Choice2Virus;
        int Choice1Rep;
        int Choice2Rep;

        int[] scoreid = new int[10];
        string[] usernames = new string[10];
        int[] scores = new int[10];

        Random rnd = new Random();
        public User currentUserGame;

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

        public void CheckAllUsed(int n)
        {

            //Variable for currently selected question to determine if has been used
            bool SelectedUsedQuestion;

            //Bool variable for determining if all questions have been used
            bool allUsed = true;

            //Loop through number of questions
            for (int i = 0; i < n; i++)
            {
                //See if curerent question has been used
                SelectedUsedQuestion = (bool)UsedQuestions[i];

                //If not then
                if (SelectedUsedQuestion == false)
                {
                    //Detemined all questions haven't been used
                    allUsed = false;
                }

            }

            //If all question have been used
            if (allUsed == true)
            {
                //Output message
                MessageBox.Show("All Questions have been used.");
                //End game
                EndGame();
                return;
            }
            //Otherwise...
            else
            {
                //Continue
                return;
            }
        }

        //Function to get question
        public void getQuestion()
        {
            //Check if all questions have been used
            CheckAllUsed(numOfQuestions);

            //Use this to pick new question's id
            QuestionID = rnd.Next(numOfQuestions);

            bool SelectedUsedQuestion = (bool)UsedQuestions[QuestionID];

            //If question id has already been used
            if (SelectedUsedQuestion == true)
            {
                //Get new question
                getQuestion();
            }

            //Else populate screen with new questions values
            else
            {
                //Get new questions values
                Question SelectedQuestion = (Question)QuestionsAL[QuestionID];
                QuestionID = SelectedQuestion.QuestionID;
                currentQuestion = SelectedQuestion.currentQuestion;
                Choice1Text = SelectedQuestion.Choice1Text;
                Choice2Text = SelectedQuestion.Choice2Text;
                Choice1Virus = SelectedQuestion.Choice1Virus;
                Choice1Rep = SelectedQuestion.Choice1Rep;
                Choice2Virus = SelectedQuestion.Choice2Virus;
                Choice2Rep = SelectedQuestion.Choice2Rep;
                Message = SelectedQuestion.Message;


                //Update text on screen
                lblQuestion.Text = SelectedQuestion.currentQuestion;
                btnChoice1.Text = SelectedQuestion.Choice1Text;
                btnChoice2.Text = SelectedQuestion.Choice2Text;
                lblTurnCounter.Text = "Turn " + turnCounter;
            }

        }

        //Fucntion checks if theres and end game state
        public void CheckValues(int VirusValue, int RepValue)
        {
            //If virus is 100 end game
            if (VirusValue >= 100)
            {
                MessageBox.Show("You Lose!");
                EndGame();
            }
            //If virus is 100 end game with a win
            else if ((RepValue >= 100) && (VirusValue <= 0))
            {
                MessageBox.Show("You Win!");
                EndGameWin();
            }
            //If virus is 0 end game
            else if (RepValue <= 0)
            {
                MessageBox.Show("You Lose!");
                EndGame();
            }
            //If no end game states the continue with game
            else
            {
                return;
            }

        }

        //Calculate outcome of a users selected answer
        public void CalculateOutcome(int VirusValue, int RepValue)
        {

            //Change the reputation and virus values acording to answer given
            reputation += RepValue;

            virus += VirusValue;

            //Make sure values dont exceed range (used for loading bar visualisers)
            if (reputation > 100)
            {
                reputation = 100;
            }

            if (virus > 100)
            {
                virus = 100;
            }

            if (reputation < 0)
            {
                reputation = 0;
            }

            if (virus < 0)
            {
                virus = 0;
            }

            //Update thse values on the screen
            lblReputation.Text = "Reputation: " + reputation;
            lblVirus.Text = "Virus: " + virus;
            prgReputation.Value = reputation;
            prgVirus.Value = virus;

            MessageBox.Show(Message);

            //Check to see if there is an endgame state (if so game will end)
            CheckValues(virus, reputation);

            //Increment turn counter
            turnCounter++;

            //Mark previous question as seen/used by the user
            UsedQuestions[QuestionID] = true;

            //Fetch new question
            getQuestion();

        }

        public void EndGameWin()
        {

            try
            {
                //Create Scores objects
                for (int j = 0; j < Scores.Length; j++)
                {
                    Scores[j] = new Scores();
                }

                int i = 0;

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

                //If current user score is greater than current lowest score in highscores
                if (turnCounter < Scores[9].Score)
                {
                    try
                    {

                        //Establish connection
                        db_connection();

                        //Insert(Update) username and turncounter/score into highscore table
                        cmd = new SqlCommand("With NewScores as ( select username, score from HIGHSCORES where ScoreID = @ScoreID ) update NewScores set username= @Username, score=@Score;", connect);
                        cmd.Parameters.AddWithValue("@Username", currentUserGame.Username);
                        cmd.Parameters.AddWithValue("@Score", turnCounter);
                        cmd.Parameters.AddWithValue("@ScoreID", Scores[9].ScoreID);
                        cmd.ExecuteNonQuery();

                        //Close connection
                        connect.Close();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error Writing new Score to DataBase - Apologies");
                    }
                }
                //If not then tell them they didnt make it :(
                else
                {
                    MessageBox.Show("You didn't make the Highscores. Better luck next time!");
                }
                //Switch to high score form
                this.Hide();
                var HighscoresWindow = new Highscores();
                HighscoresWindow.currentUserHighscores = currentUserGame;
                HighscoresWindow.Closed += (s, args) => this.Close();
                HighscoresWindow.Show();

            }
            catch (SqlException)
            {
                MessageBox.Show("Error Retrieving Scores from DataBase - Apologies");
                //Switch to high score form
                this.Hide();
                var HighscoresWindow = new Highscores();
                HighscoresWindow.currentUserHighscores = currentUserGame;
                HighscoresWindow.Closed += (s, args) => this.Close();
                HighscoresWindow.Show();
            }
        }

        public void EndGame()
        {
            try
            {
                db_connection();
                //Switch to high score form
                this.Hide();
                var HighscoresWindow = new Highscores();
                HighscoresWindow.currentUserHighscores = currentUserGame;
                HighscoresWindow.Closed += (s, args) => this.Close();
                HighscoresWindow.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error Retrieving Scores from DataBase - Apologies");
                //Switch to menu form and carry user object over
                this.Hide();
                var MenuWindow = new VirusGame();
                MenuWindow.currentUserMenu = currentUserGame;
                MenuWindow.Closed += (s, args) => this.Close();
                MenuWindow.Show();
            }
        }
        public MainGame()
        {
            InitializeComponent();
        }

        public int NumberOfQuestions()
        {
            //Get the number of questions
            db_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT (*) FROM dbo.GAMEQUESTIONS";
            cmd.Connection = connect;

            //Save as local variable
            numOfQuestions = (int)cmd.ExecuteScalar();

            connect.Close();

            return numOfQuestions;
        }

        public void PopulateQuestions(int n)
        {
            //Loop through number of questions
            for (int i = 0; i < n; i++)
            {
                db_connection();

                //Get all of the selected question attributes
                SqlCommand cmd = new SqlCommand("SELECT * FROM GAMEQUESTIONS WHERE QuestionID = @QuestionID", connect);
                cmd.Parameters.AddWithValue("@QuestionID", i);
                //Read values
                SqlDataReader sdl = cmd.ExecuteReader();

                //Whilst reading values, make local varable values to those from columns in selected row
                while (sdl.Read())
                {
                    QuestionsAL.Add(new Question(Int32.Parse(sdl[0].ToString()), sdl[1].ToString(), sdl[2].ToString(), sdl[3].ToString(), Int32.Parse(sdl[4].ToString()), Int32.Parse(sdl[5].ToString()), Int32.Parse(sdl[6].ToString()), Int32.Parse(sdl[7].ToString()), sdl[8].ToString()));
                }

                //close connection
                connect.Close();
            }
        }

        //On form load
        private void MainGame_Load(object sender, EventArgs e)
        {
            numOfQuestions = NumberOfQuestions();

            PopulateQuestions(numOfQuestions);

            //Populate form elements
            lblQuestion.Text = currentQuestion;
            lblReputation.Text = "Reputation: " + reputation;
            lblVirus.Text = "Virus: " + virus;
            lblTurnCounter.Text = "Turn " + turnCounter;
            btnChoice1.Text = Choice1Text;
            btnChoice2.Text = Choice2Text;


            prgReputation.Style = ProgressBarStyle.Continuous;
            prgReputation.Maximum = 100;
            prgReputation.Value = reputation;

            prgVirus.Style = ProgressBarStyle.Continuous;
            prgVirus.Maximum = 100;
            prgVirus.Value = virus;

            //False value
            bool falseval = false;

            //Mark all questions as unused/unseen
            for (int i = 0; i < numOfQuestions; i++)
            {
                UsedQuestions.Add(falseval);
            }

            //Fetch question
            getQuestion();
        }

        //User selects choice1/Left button
        private void btnChoice1_Click(object sender, EventArgs e)
        {
            //Calculate outcome of this choice 1
            CalculateOutcome(Choice1Virus, Choice1Rep);
        }

        //User selects choice2/Right button
        private void btnChoice2_Click(object sender, EventArgs e)
        {
            //Calculate outcome of this choice 2
            CalculateOutcome(Choice2Virus, Choice2Rep);
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
