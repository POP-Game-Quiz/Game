using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using static signuo.LogForm;

namespace signuo
{
    public partial class Ranks : Form
    {
        public Ranks()
        {
            InitializeComponent();
            ShowScore();
        }
        private void ShowScore()
        {
            

            SqlCommand cmd = new SqlCommand(@"select (score) from [dbo].[signup]", conn);
            
            {
                conn.Open();

                using (SqlDataReader read = cmd.ExecuteReader())

                {
                    while (read.Read())
                    {
                        listBox1.Text = (read["score"].ToString());
                    }
                }
                conn.Close();
            }
            return;
        }

    }
}
