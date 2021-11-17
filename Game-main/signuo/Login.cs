using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace signuo
{
    public partial class LogForm : Form
    {
     
        //sql connection
        //if the conn string dosent work 
        // to find this, double click database1 and in the properies of the database copy conn string, paste it into the variable 
        public static SqlConnection conn = new SqlConnection
        (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bestk\Documents\University\CCCU\Year 2\Software Engineering\Game-main\Game-main\signuo\Database1.mdf;Integrated Security = True");

        public static string User;
         public LogForm()
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
            try
            {
                if (ConfirmPasswordTextbox.Text == PasswordTextBox.Text)
                {
                    SqlCommand cmd = new SqlCommand(@"insert into [dbo].[signup] ([user],[pass],[score]) values ('" + UserNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + 0 + "')", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LabelFeedback.Text = "Account created!";
                }
                else
                {
                    LabelFeedback.Text = "Please re-enter the password!";
                }
            }
            catch (Exception)//couldnt find an exception specific to the queries 
            {
                LabelFeedback.Text = "This Username already exist!";
            }
        }
        private void LoginButton(object sender, EventArgs e)
        {

            SqlDataAdapter adap = new SqlDataAdapter(@"select count (*) from [dbo].[signup] where [dbo].[signup].[user] ='" + UserNameTextBox.Text + "' and [dbo].[signup].[pass] ='" + PasswordTextBox.Text + "'", conn);
            //creates table and adds data
            DataTable dt = new DataTable();
            adap.Fill(dt);
          
            if (dt.Rows[0][0].ToString() == "1" )
            {
                //fills global variable with username
                User = UserNameTextBox.Text;

                //if logged in, hides this window and 
                this.Hide();

                //shows the quizz app/window
                Quiz QuizForm = new Quiz();
                QuizForm.Show();
            }
            else
            {
                LabelFeedback.Text = "Account does not exist!";
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
