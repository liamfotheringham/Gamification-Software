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
    public partial class Admin : MaterialForm
    {
        public User currentUserAdminPanel;
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

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //Refresh DGV
            refreshDataView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //When user selects a row
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectrow = dataGridView1.Rows[selectrowindex];

                    //Change selected question labels to the appropriate values
                    txtQuestionID.Text = Convert.ToString(selectrow.Cells[0].Value);
                    txtQuestionText.Text = Convert.ToString(selectrow.Cells[1].Value);
                    txtChoice1Text.Text = (Convert.ToString(selectrow.Cells[2].Value));
                    txtChoice2Text.Text = (Convert.ToString(selectrow.Cells[3].Value));
                    txtChoice1Virus.Text = Convert.ToString(selectrow.Cells[4].Value);
                    txtChoice1Rep.Text = Convert.ToString(selectrow.Cells[5].Value);
                    txtChoice2Virus.Text = Convert.ToString(selectrow.Cells[6].Value);
                    txtChoice2Rep.Text = (Convert.ToString(selectrow.Cells[7].Value));
                    txtMessage.Text = (Convert.ToString(selectrow.Cells[8].Value));


                }
            }
            catch
            {
                //Throw an exception
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AddQuestion(int QuestionID, string QuestionText, string Choice1Text, string Choice2Text, int Choice1Virus, int Choice1Rep, int Choice2Virus, int Choice2Rep, string Message)
        {
            try
            {
                //Establish connection
                db_connection();

                //Check if question with the selected ID doesnt already exist
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GAMEQUESTIONS WHERE QuestionID = @QuestionID", connect);

                cmd.Parameters.AddWithValue("@QuestionID", QuestionID);

                var result = cmd.ExecuteScalar();

                //If question ID already exists then tell user
                if (result != null)
                {
                    MessageBox.Show("A Question with this ID already exists", "Duplicate",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Otherwise, insert question into the database
                else
                {
                    cmd = new SqlCommand("INSERT INTO dbo.GAMEQUESTIONS (QuestionID, QuestionText, Choice1, Choice2, Choice1Virus, Choice1Rep, Choice2Virus, Choice2Rep, Message) VALUES (@QuestionID, @QuestionText, @Choice1, @Choice2, @Choice1Virus, @Choice1Rep, @Choice2Virus, @Choice2Rep, @Message)", connect);
                    cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                    cmd.Parameters.AddWithValue("@QuestionText", QuestionText);
                    cmd.Parameters.AddWithValue("@Choice1", Choice1Text);
                    cmd.Parameters.AddWithValue("@Choice2", Choice2Text);
                    cmd.Parameters.AddWithValue("@Choice1Virus", Choice1Virus);
                    cmd.Parameters.AddWithValue("@Choice1Rep", Choice1Rep);
                    cmd.Parameters.AddWithValue("@Choice2Virus", Choice2Virus);
                    cmd.Parameters.AddWithValue("@Choice2Rep", Choice2Rep);
                    cmd.Parameters.AddWithValue("@Message", Message);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show(i + " Question Added");
                    }
                }

                //Close Connection
                connect.Close();

                //Refresh DGV
                refreshDataView();
            }
            catch
            {
                //Inform the user an Error has occured
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("An Error has occured", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                //Add questions to database
                AddQuestion(Convert.ToInt32(txtQuestionID.Text), txtQuestionText.Text, txtChoice1Text.Text, txtChoice2Text.Text, Convert.ToInt32(txtChoice1Virus.Text), Convert.ToInt32(txtChoice1Rep.Text), Convert.ToInt32(txtChoice2Virus.Text), Convert.ToInt32(txtChoice2Rep.Text), txtMessage.Text);

            }
            catch
            {
                //Inform the user that there is an invalid input
                MessageBox.Show("Invalid Input Detected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtClear_Click(object sender, EventArgs e)
        {
            //Clear all textboxes
            txtQuestionID.Text = "";
            txtQuestionText.Text = "";
            txtChoice1Text.Text = "";
            txtChoice2Text.Text = "";
            txtChoice1Rep.Text = "";
            txtChoice1Virus.Text = "";
            txtChoice2Rep.Text = "";
            txtChoice2Virus.Text = "";
            txtMessage.Text = "";
        }

        public void DeleteQuestion(int QuestionID)
        {
            try
            {
                //Get user to confirm
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this question?", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                //If Yes then delete question from database
                if (result == DialogResult.Yes)
                {
                    //Establish connection to database
                    db_connection();

                    //Delete question
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.GAMEQUESTIONS WHERE QuestionID = @QuestionID", connect);
                    cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    //close connection
                    connect.Close();

                    //Refresh DGV
                    refreshDataView();
                }
            }
            catch
            {
                //Tell user an error has occured
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("An Error has occured", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete Question
                DeleteQuestion(Convert.ToInt32(txtDeleteQuestionID.Text));
            }
            catch
            {
                //Inform user there is an invalid input
                MessageBox.Show("Invalid Input Detected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get all of the questions from the database and displays them to the DGV
        void refreshDataView()
        {
            //Establish connection to database
            db_connection();

            //Update DGV
            SqlCommand cmd = new SqlCommand("SELECT * FROM GAMEQUESTIONS;", connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            //Close connection
            connect.Close();
        }

        public void UpdateQuestion(int QuestionID, string QuestionText, string Choice1Text, string Choice2Text, int Choice1Virus, int Choice1Rep, int Choice2Virus, int Choice2Rep, string Message)
        {
            try
            {
                //Establish connection to the database
                db_connection();

                SqlCommand cmd = new SqlCommand("UPDATE dbo.GAMEQUESTIONS SET QuestionID = @QuestionID, QuestionText = @QuestionText, Choice1 = @Choice1, Choice2 = @Choice2, Choice1Virus = @Choice1Virus, Choice1Rep = @Choice1Rep, Choice2Virus = @Choice2Virus, Choice2Rep = @Choice2Rep, Message = @Message WHERE QuestionID = @QuestionID", connect);
                cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                cmd.Parameters.AddWithValue("@QuestionText", QuestionText);
                cmd.Parameters.AddWithValue("@Choice1", Choice1Text);
                cmd.Parameters.AddWithValue("@Choice2", Choice2Text);
                cmd.Parameters.AddWithValue("@Choice1Virus", Choice1Virus);
                cmd.Parameters.AddWithValue("@Choice1Rep", Choice1Rep);
                cmd.Parameters.AddWithValue("@Choice2Virus", Choice2Virus);
                cmd.Parameters.AddWithValue("@Choice2Rep", Choice2Rep);
                cmd.Parameters.AddWithValue("@Message", Message);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                //Close connection
                connect.Close();

                //Refresh DGV
                refreshDataView();
            }
            catch
            {
                //Inform user an error has occured
                SqlCommand cmd = new SqlCommand("EXECUTE InvalidStoredProcedure", connect);
                MessageBox.Show("An Error has occured", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Update question
                UpdateQuestion(Convert.ToInt32(txtQuestionID.Text), txtQuestionText.Text, txtChoice1Text.Text, txtChoice2Text.Text, Convert.ToInt32(txtChoice1Virus.Text), Convert.ToInt32(txtChoice1Rep.Text), Convert.ToInt32(txtChoice2Virus.Text), Convert.ToInt32(txtChoice2Rep.Text), txtMessage.Text);
            }
            catch
            {
                //Inform user there is an invalid input
                MessageBox.Show("Invalid Input Detected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Switch to menu form
            this.Hide();
            var MenuWindow = new VirusGame();
            MenuWindow.currentUserMenu = currentUserAdminPanel;
            MenuWindow.Closed += (s, args) => this.Close();
            MenuWindow.Show();
        }

        private void txtChoice2Virus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
