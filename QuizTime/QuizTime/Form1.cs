using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTime
{
    public partial class Form1 : Form
    {
        // App varibles

        int QuestionNum = 1;
        int CorrectAns;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            QuestionOrder(QuestionNum);
            
        }

        private void QuestionOrder(int QuestionNumber)
        {
            switch(QuestionNumber)
            {
                case 1:
                    QuestionQ.Text = " What nut is used to make marzipan ?";
                    button1.Text = "Walnut";
                    button2.Text = "Almond";
                    button3.Text = "Huzlnut";
                    button4.Text = "Coconut";
                    break;

                case 2:
                    QuestionQ.Text = " What's the capital of Spain ?";
                    button1.Text = "Madrid";
                    button2.Text = "Barcelona";
                    button3.Text = "Valencia";
                    button4.Text = "Seville";
                    break;

                case 3:
                    QuestionQ.Text = " Who was the president of the United States of America before Donald Trump ?";
                    button1.Text = "Joe Biden";
                    button2.Text = "George Bush";
                    button3.Text = "Bill Clinton";
                    button4.Text = "Barack Obama";
                    break;

                case 4:
                    QuestionQ.Text = " How many wives did Henry VIII have ?";
                    button1.Text = "Seven";
                    button2.Text = "Ten";
                    button3.Text = "Six";
                    button4.Text = "Five";
                    break;

                case 5:
                    QuestionQ.Text = " What's the highest mountain in the world ?";
                    button1.Text = "Mount Kosciuszko";
                    button2.Text = "Mount Everest";
                    button3.Text = "Mount Fuji";
                    button4.Text = "Mount Logan";
                    break;

            }
        }
        public void SelectAnswer()
        {

        }
    }
}
