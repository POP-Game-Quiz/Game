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
            getRank();
        }
        private void ShowRank()
        {

            SqlDataAdapter adap = new SqlDataAdapter(@"select user from [dbo].[signup] order by (score) asc ", conn);

            DataTable dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    //.Text += row.ItemArray[0].ToString() + " -> " + row.ItemArray[1].ToString() + Environment.NewLine;
                }
            }
            /*using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    for (int i =0;i< cmd.Parameters.Count; i++)
                    {

                    }
                }
            }*/

        }
        private void getRank()
        { int i = 1;
            

            SqlCommand cmd = new SqlCommand(@"select (score) from [dbo].[signup] ", conn);
           // cmd.Parameters.AddWithValue("@usr", User);
           
            try
            {
                conn.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        label1.Text = read["user"].ToString();
                        
                        label2.Text = (read["score"].ToString());

                    }

                }
                conn.Close();
            }
             
            catch (Exception)
            {
              
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getRank();
        }

       
    }
}
