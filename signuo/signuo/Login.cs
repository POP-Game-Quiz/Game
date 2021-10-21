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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label3.Hide();
            textBox3.Hide();
            button1.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Show();
            textBox3.Show();
            button1.Show();
            button3.Hide();
        }
        private void submit(object sender, EventArgs e)
        {
           
            if (textBox3.Text == textBox2.Text)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PubQuiz\Game-main\signuo\signuo\Database1.mdf;Integrated Security=True");
                SqlCommand cmdins = new SqlCommand(@"insert into [dbo].[signup] ([user],[pass]) values ('" + textBox1.Text + "','" + textBox2.Text + "')", sqlcon);

                sqlcon.Open();
                cmdins.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("added");
            }
            else
            {
                MessageBox.Show("the passowrd dosen`t match");
            }

        }

       
        //login
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PubQuiz\Game-main\signuo\signuo\Database1.mdf;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter(@"select count (*) from [dbo].[signup] where [dbo].[signup].[user] ='" + textBox1.Text + "' and [dbo].[signup].[pass] ='" + textBox2.Text + "'", sqlcon);

            //creates table and adds data
            DataTable dt = new DataTable();
            adap.Fill(dt);
          

            if (dt.Rows[0][0].ToString() == "1" )
            {
                //if logged in, hides this window and 
                this.Hide();
                //shows the quizz app/window
                Quiz qq = new Quiz();
                qq.Show();
            }
            else
            {
                MessageBox.Show("please try again","alert" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
