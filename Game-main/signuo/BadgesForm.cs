using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signuo
{
    public partial class BadgesForm : Form
    {
        public BadgesForm()
        {
            InitializeComponent();
            // checking the the badges eligibility
            int currentScore = Quiz.userScore;
            switch (currentScore)
            {
                case 10:
                    //shows the quizz app/window
                    //Quiz BadgesForm = new Quiz();
                    
                    CongratsMessage.Text = "Congrats you have earned a bronze award!";
                    pictureBoxBronze.Visible = true;
                    pictureBoxSilver.Visible = false;
                    pictureBoxGold.Visible = false;
                    Task.Delay(1000);
                    this.Hide();

                    break;
                case 20:
                    
                    CongratsMessage.Text = "Congrats you have earned a silver award!";
                    pictureBoxBronze.Visible = false;
                    pictureBoxSilver.Visible = true;
                    pictureBoxGold.Visible = false;
                 
                    break;
                case 30:
                    this.Show();
                    CongratsMessage.Text = "Congrats you have earned a gold award!";
                    pictureBoxBronze.Visible = false;
                    pictureBoxSilver.Visible = false;
                    pictureBoxGold.Visible = true;
                   
                    break;

            }
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
