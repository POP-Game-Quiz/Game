using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using static signuo.Login;

namespace signuo
{
    public partial class Quiz : Form
    {
        private int j = 1;
        //  private int scoree;
        private string userAnswer;
        private string correctAnswer;

        private static List<AnswerButton> AnswerBtn = new List<AnswerButton>();

        public Quiz()
        {
            InitializeComponent();
            //initializes the first question straight away

            AnswerBtn = new List<AnswerButton>()
                        {
                            answerButton1,
                            answerButton2,
                            answerButton3,
                            answerButton4
                        };
            //bring up the first question
            QuizzFill(j);
            //initial display the score to label from database
            GetScore();

        }

        private void SubmitBt(object sender, EventArgs e)
        {

            foreach (AnswerButton aBtn in AnswerBtn)
            {
                if (aBtn.Checked)
                {
                    //sets userAnswer to the selected radiobutton
                    userAnswer = aBtn.Text;
                    break;
                }
            };

            if (userAnswer == correctAnswer)
            {
                // idealy we wont use message boxes
                MessageBox.Show("Correct answer");

                //increments score by 1 
                // updates old score + new score every "submit" click
                Score();
            }
            else
            {
                MessageBox.Show("Incorrect Answer");
            }
            //display the score to the label from database
            GetScore();
        }

        private void NextButton(object sender, EventArgs e)
        {
            //increments j where j is the row number of the table 
            j++;
            
            QuizzFill(j);
        }

        private void QuizzFill(int i )
        {
            
            SqlCommand cmd = new SqlCommand(@"select top(" + i + ")* from [dbo].[Quest];", conn);
            try
            {
                conn.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                       
                        label1.Text = (read["question"].ToString());

                        string first  = (read["cAnswer"].ToString());
                        string second  = (read["wAnswer"].ToString());
                        string third = (read["wrAnswer"].ToString());
                        string fourth = (read["wroAnswer"].ToString());

                        List<string> populateAns = new List<string>()
                                                           { first,
                                                             second,
                                                             third,
                                                             fourth
                                                           };
                        int hh = new Random().Next(populateAns.Count);

                        AnswerButton1.Text = populateAns[hh];
                        AnswerButton2.Text = populateAns[hh];
                        AnswerButton3.Text = populateAns[hh];
                        AnswerButton4.Text = populateAns[hh];
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
        private void Score()
        {
            conn.Open();

            SqlCommand cmdScore = new SqlCommand(@"UPDATE [dbo].[signup] SET [dbo].[signup].[score] =[score]+(1) WHERE [dbo].[signup].[user] in (@usr)", conn);

            cmdScore.Parameters.AddWithValue("@usr", User);

            cmdScore.ExecuteNonQuery();
            conn.Close();
        }

        private void GetScore()
        {
            SqlCommand cmd = new SqlCommand(@"select (score) from [dbo].[signup] where  [dbo].[signup].[user] in (@usr)", conn);
            cmd.Parameters.AddWithValue("@usr", User);
            try
            {
                conn.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ScoreLabel.Text = (read["score"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
