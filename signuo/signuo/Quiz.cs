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

namespace signuo
{
    public partial class Quiz : Form
    {
        private int j=1;
        private int score = 0;
        private string userAnswer;
        private string correctAnswer;

        private static List<RadioButton> radioBtn = new List<RadioButton>();

        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciuca\source\repos\Game\signuo\signuo\Database1.mdf;Integrated Security=True");
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

            QuizzFill(j);
            
        }
       
        private void SubmitBt(object sender, EventArgs e)
        {
                foreach(RadioButton rBtn in radioBtn)
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
                MessageBox.Show("Correct answer");
                //score
                score++;
                ScoreLabel.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect Answer");
            }   
        }

        private void NextButton(object sender, EventArgs e)
        {
            //increments j where j is the row number of the table 
            j++;
            
            QuizzFill(j);
        }

        private void QuizzFill(int i )
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

                        string correctAn  = (read["cAnswer"].ToString());
                        string wrongA = (read["wAnswer"].ToString());
                        string wrongAn = (read["wrAnswer"].ToString());
                        string wrongAns = (read["wroAnswer"].ToString());

                        //sets my correct answer to a global variable 
                        correctAnswer = correctAn;

                        List<string> answerList = new List<string>()
                                                        {  correctAn,
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

            /*SqlCommand cmdScore = new SqlCommand(@"update score set score=max(score,@score) where user='" + User + "', conn);


           cmdScore.Parameters.AddWithValue("@score", score);
            conn.Open();
            int result = cmdScore.ExecuteNonQuery();
            conn.Close();*/
        }
    }
}
