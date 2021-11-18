using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using static signuo.LogForm;
using System.Data;

namespace signuo
{
    public partial class Ranky : Form
    {
        public Ranky()
        {
            InitializeComponent();
            
            ShowRank();
        }
        private void ShowRank()
        {

            SqlDataAdapter adap = new SqlDataAdapter(@"SELECT TOP 10 * FROM [dbo].[signup] order by (score) desc ", conn);
            conn.Open();
            DataTable dt = new DataTable();
            adap.Fill(dt);


            // this can be made better in the future, but it works  :D
            rank1.Text = dt.Rows[0][0].ToString() + Environment.NewLine;
            rank1S.Text = dt.Rows[0][2].ToString() + Environment.NewLine;
            rank2.Text = dt.Rows[1][0].ToString() + Environment.NewLine;
            rank2S.Text = dt.Rows[1][2].ToString() + Environment.NewLine;
            rank3.Text = dt.Rows[2][0].ToString() + Environment.NewLine;
            rank3s.Text = dt.Rows[2][2].ToString() + Environment.NewLine;
            rank4.Text = dt.Rows[3][0].ToString() + Environment.NewLine;
            rank4s.Text = dt.Rows[3][2].ToString() + Environment.NewLine;
            rank5.Text = dt.Rows[4][0].ToString() + Environment.NewLine;
            rank5s.Text = dt.Rows[4][2].ToString() + Environment.NewLine;

            conn.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (trackBar1.Value == 1)
            {
                this.BackColor = System.Drawing.Color.Aqua;
                this.ForeColor = System.Drawing.Color.FromArgb(41, 52, 73);
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(41, 52, 73);
                this.ForeColor = System.Drawing.Color.FromArgb(192, 255, 192);

            }
        }
    }
}
