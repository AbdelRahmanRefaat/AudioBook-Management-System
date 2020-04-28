using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace orderla
{
    public partial class bestsell : UserControl
    {
        public bestsell()
        {
            InitializeComponent();
            try
            {
                string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                MySqlConnection mcon = new MySqlConnection(con);
                MySqlCommand query = new MySqlCommand("call tit();", mcon);
                MySqlDataReader myread;
                query.CommandTimeout = 50;
                mcon.Open();
                myread = query.ExecuteReader();
                int count = 1;
                while (myread.Read())
                {
                    if(count == 1)
                    {
                        labelF.Text = myread.GetString("bookname");
                        labelS.Text = myread.GetString("author");
                    }
                    else if(count == 2)
                    {
                        bunifuCustomLabel2.Text = myread.GetString("bookname");
                        bunifuCustomLabel1.Text = myread.GetString("author");
                    }
                    else if(count == 3)
                    {
                        bunifuCustomLabel4.Text = myread.GetString("bookname");
                        bunifuCustomLabel3.Text = myread.GetString("author");
                    }
                    else if(count == 4)
                    {
                        bunifuCustomLabel6.Text = myread.GetString("bookname");
                        bunifuCustomLabel5.Text = myread.GetString("author");
                    }
                    else if(count == 5)
                    {
                        bunifuCustomLabel8.Text = myread.GetString("bookname");
                        bunifuCustomLabel7.Text = myread.GetString("author");
                    }
                    count++;
                }
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
