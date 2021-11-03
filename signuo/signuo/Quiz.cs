﻿using System;
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

        private static List<RadioButton> radioBtn = new List<RadioButton>();

        public Quiz()
        {
            InitializeComponent();
            //initializes the first question str8 away

            radioBtn = new List<RadioButton>()
                        {
                            radioButton1,
                            radioButton2,
                            radioButton3,
                            radioButton4
                        };
            //bring up the first question
            QuizzFill(j);
            //initial display the score to label from database
            GetScore();

        }

        private void SubmitBt(object sender, EventArgs e)
        {

            foreach (RadioButton rBtn in radioBtn)
            {
                if (rBtn.Checked)
                {
                    //sets userAnswer to the selected radiobutton
                    userAnswer = rBtn.Text;
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

        private void QuizzFill(int i)
        {
            //selects the row 
            SqlCommand cmd = new SqlCommand(@"select top(" + i + ")* from [dbo].[Quest];", conn);
            try
            {
                conn.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                        QuestionLabel.Text = (read["question"].ToString());

                        string correctAns = (read["cAnswer"].ToString());
                        string wrongA = (read["wAnswer"].ToString());
                        string wrongAn = (read["wrAnswer"].ToString());
                        string wrongAns = (read["wroAnswer"].ToString());

                        //sets my correct answer to a global variable 
                        correctAnswer = correctAns;

                        List<string> answerList = new List<string>()
                                                        {  correctAns,
                                                           wrongA,
                                                           wrongAn,
                                                           wrongAns
                                                        };

                        foreach (RadioButton rbtn in radioBtn)
                        {

                            string currentAnswer = answerList[new Random().Next(answerList.Count)];

                            //sets the radiobutton with the random answer
                            //then removes that answer from the  answer list 
                            rbtn.Text = currentAnswer;
                            answerList.RemoveAt(answerList.IndexOf(currentAnswer));
                        }
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
            SqlCommand cmd = new SqlCommand(@"select (score) from [dbo].[signup] where  [dbo].[signup].[user] in (@usr)" , conn);
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
        private void Score()
        {

            /* SqlCommand cmdScore = new SqlCommand(@"update score set score=max(score,@score) where user='" + User + "', conn);

            cmdScore.Parameters.AddWithValue("@score", score);
            conn.Open();
                        int result = cmdScore.ExecuteNonQuery();
            conn.Close();*/
        }
    }
}