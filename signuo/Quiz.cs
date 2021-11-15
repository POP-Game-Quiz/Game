using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using static signuo.LogForm;


namespace signuo
{
    public partial class Quiz : Form
    {
        private int j = 1;
        private int Tick = 20;
       public static int userScore;
        private string userAnswer;
        private string correctAnswer;

        private static List<RadioButton> radioBtn = new List<RadioButton>();

        public Quiz()
        {
            InitializeComponent();
            // an if statement if j == 31 or 30 "after the last question" then show the rank button and a congrats label ?

            timer1.Start();
            timerLabel.Text = Tick + " Seconds";

            radioBtn = new List<RadioButton>()
                        {
                            radioButton1,
                            radioButton2,
                            radioButton3,
                            radioButton4
                        };
            //bring up the first question
            QuizzFill(j);
            //initial display of the score to label, from database
            GetScore();

            
            /*foreach (RadioButton aBtn in radioBtn)
            {
                //gotta make this button flatStyle.popup somehow
                aBtn.Appearance= Appearance.Button; 
            }*/
        }
        private void SubmitBt(object sender, EventArgs e)
        {
            timer1.Stop();

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
                FeedbackLabel.Text = "Correct answer";

                //increments score by 1 
                // updates old score + new score every "submit" click
                Score();
               
                
            }
            else
            {
                FeedbackLabel.Text =  "Incorrect Answer";
            }
            //display the score to the label from database
            GetScore();
            SubmitBtnn.Hide();

            if (userScore==10 || userScore==20 || userScore== 30)
            {
                BadgesForm badgesForm = new BadgesForm();
                badgesForm.Show();
            }
        }

     

        private void NextButton(object sender, EventArgs e)
        {
            Tick = 20;
            timer1.Start();
            timerLabel.Text = Tick + " Seconds";

            

            //increments j where j is the row number of the table 
            j++;
             
            QuizzFill(j);

            SubmitBtnn.Show();
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
        private void  GetScore()
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
                        userScore = Convert.ToInt32(ScoreLabel.Text);
                    }
                }
               
            }
            finally
            {
                conn.Close();
            }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick--;
            timerLabel.Text = Tick + " Seconds";
            if (Tick == 0)
            {
                timerLabel.Text = "Sorry, you run out of time";
                timer1.Stop();

                SubmitBtnn.Hide();
                NextBtn.Hide();

                ExitBtn.Location = new System.Drawing.Point(650, 10);
                ExitBtn.Size = new System.Drawing.Size(94, 94);
                // a button where it takes you to rank form
            }
        }

        private void ColorSwitch(object sender, EventArgs e)
        {
            if (ColorSwich.Value == 1)
            {
                this.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                this.ForeColor = System.Drawing.Color.FromArgb(41, 52, 73);
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(41, 52, 73);
                this.ForeColor = System.Drawing.Color.FromArgb(192, 255, 192);
                
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}