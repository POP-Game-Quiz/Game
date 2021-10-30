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
        private bool AnswerButton1Clicked = false;

        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciuca\source\repos\Game\signuo\signuo\Database1.mdf;Integrated Security=True");
        public Quiz()
        {
            InitializeComponent();
            //initializes the first question str8 away
            QuizzFill(j);
            
        }
       
        private void SubmitBt(object sender, EventArgs e)
        {
            if (AnswerButton1Clicked == true)
            {
               
                SqlDataAdapter adap = new SqlDataAdapter(@"select count (cAnswer) from [dbo].[Quest] where [dbo].[Quest].[cAnswer] ='" + AnswerButton1 + "'", conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
               
                MessageBox.Show("Correct Answer");
               
                //score
                score++;
                ScoreLabel.Text = score.ToString();

            }
            else
            {
                MessageBox.Show("Wrong Answer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            /* SqlCommand cmdScore = new SqlCommand(@"update score set score=max(score,@score) where user='" + User + "', conn);

            cmdScore.Parameters.AddWithValue("@score", score);
            conn.Open();
                        int result = cmdScore.ExecuteNonQuery();
            conn.Close();*/
        }

        private void AnswerButton1_Click(object sender, EventArgs e)
        {
            AnswerButton1Clicked = true;
        }
    }
}
