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
            ConfirmPasswordLabel.Hide();
            ConfirmPasswordInput.Hide();
            SubmitButton.Hide();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            ConfirmPasswordLabel.Show();
            ConfirmPasswordInput.Show();
            SubmitButton.Show();
            SignUpButton.Hide();
        }
        private void Submit(object sender, EventArgs e)
        {
           
            if (ConfirmPasswordInput.Text == PasswordInput.Text)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bestk\Documents\University\CCCU\Year 2\Software Engineering\Game - main\Game - main\signuo\signuo\Database1.mdf;Integrated Security=True");
                SqlCommand cmdins = new SqlCommand(@"insert into [dbo].[signup] ([user],[pass]) values ('" + UserNameInput.Text + "','" + PasswordInput.Text + "')", sqlcon);

                sqlcon.Open();
                cmdins.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("You Successfully Created an Account.");
            }
            else
            {
                MessageBox.Show("You Have Entered Passwords That Do Not Match, Please Try Again.");
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\bestk\Documents\University\CCCU\Year 2\Software Engineering\Game - main\Game - main\signuo\signuo\Database1.mdf;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter(@"select count (*) from [dbo].[signup] where [dbo].[signup].[user] ='" + UserNameInput.Text + "' and [dbo].[signup].[pass] ='" + PasswordInput.Text + "'", sqlcon);

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
                MessageBox.Show("Incorrect Password, Please Try Again","ALERT" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
