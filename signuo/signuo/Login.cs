using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace signuo
{
    public partial class Login : Form
    {
        //sql connection
        //if the conn string dosent work 
        //  to find this, double click database1 and in the properies of the database copy conn string, paste it into the variable 
        public static SqlConnection conn = new SqlConnection
        (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\QuizProject\signuo\signuo\Database1.mdf;Integrated Security=True");

        public static string User;
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
            label3.Hide();
            label4.Hide();
        }
        private void Submit(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextbox.Text == PasswordTextBox.Text)
            {
                SqlCommand cmd = new SqlCommand(@"insert into [dbo].[signup] ([user],[pass],[score]) values ('" + UserNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + 0 + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
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

            if (dt.Rows[0][0].ToString() == "1")
            {
                User = UserNameTextBox.Text;

                //if logged in, hides this window and 
                this.Hide();

                //shows the quizz app/window
                Quiz QuizForm = new Quiz();
                QuizForm.Show();
            }
            else
            {
                MessageBox.Show("Please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }

}
