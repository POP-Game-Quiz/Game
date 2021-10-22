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
      public static string AllConnection = "" ;
        //sql connection
        //if the conn string dosent work you need to copy paste your string into sql conn
        
        public SqlConnection conn = new SqlConnection
            (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+AllConnection+";Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            ConfirmPasswordLabel.Hide();
            ConfirmPasswordTextbox.Hide();
            SubmitButton1.Hide();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            ConfirmPasswordLabel.Show();
            ConfirmPasswordTextbox.Show();
            SubmitButton1.Show();
            SignUpButton.Hide();
        }
        private void Submit(object sender, EventArgs e)
        { 
            if (ConfirmPasswordTextbox.Text == PasswordTextBox.Text)
            {
                SqlCommand cmdins = new SqlCommand(@"insert into [dbo].[signup] ([user],[pass]) values ('" + UserNameTextBox.Text + "','" + PasswordTextBox.Text + "')", conn);

                conn.Open();
                cmdins.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("Please re-enter the password, they do not match");
            }
        }

        //login
        private void LoginButton(object sender, EventArgs e)
        {
  
            SqlDataAdapter adap = new SqlDataAdapter(@"select count (*) from [dbo].[signup] where [dbo].[signup].[user] ='" + UserNameTextBox.Text + "' and [dbo].[signup].[pass] ='" + PasswordTextBox.Text + "'", conn);

            //creates table and adds data
            DataTable dt = new DataTable();
            adap.Fill(dt);
          
            if (dt.Rows[0][0].ToString() == "1" )
            {
                //if logged in, hides this window and 
                this.Hide();

                //shows the quizz app/window
                Quiz QuizForm = new Quiz();
                QuizForm.Show();
            }
            else
            {
                MessageBox.Show("Please try again","Alert" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }

}
