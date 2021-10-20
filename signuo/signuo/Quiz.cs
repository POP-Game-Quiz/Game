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
        string[] answ;

        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciuca\source\repos\signuo\signuo\Database1.mdf;Integrated Security=True");
       
        public Quiz()
        {
            InitializeComponent();
            //initializes the first question str8 away
            QuizzFill(j);
            
        }
       
        private void SubmitBt(object sender, EventArgs e)
        {
            // randomise radiobutons, doing so randomises the answer
            if (radioButton1.Checked)
            {
               
                SqlDataAdapter adap = new SqlDataAdapter(@"select count (cAnswer) from [dbo].[Quest] where [dbo].[Quest].[cAnswer] ='" + radioButton1.Checked + "'", conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
               
                MessageBox.Show("correct");
               
                //sc
                score++;
                label2.Text = score.ToString();

            }
            else
            {
                MessageBox.Show("fail", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void NextBt(object sender, EventArgs e)
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
                     //  [radioButton1, radioButton2, radioButton3, radioButton4];
                            label1.Text       = (read["question"].ToString());
                            radioButton1.Text = (read["cAnswer"].ToString());
                            radioButton2.Text = (read["wAnswer"].ToString());
                            radioButton3.Text = (read["wrAnswer"].ToString());
                            radioButton4.Text = (read["wroAnswer"].ToString());
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
