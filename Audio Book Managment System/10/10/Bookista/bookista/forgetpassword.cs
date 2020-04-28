using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bookista
{
    public partial class forgetpassword : UserControl
    {
        bool male = false, female = false;
        class forget
        {
            public string search(string email, bool run1)
            {
                string pass = "";
                string con = "Server=localhost;Database=Bookista;User Id=root;Password =;SslMode=none; ";
                string now = "select forget('" + email + "','" + run1 + "');";
                MySqlConnection mcon = new MySqlConnection(con);
                MySqlCommand query = new MySqlCommand(now, mcon);
                query.CommandTimeout = 50;
                mcon.Open();
                pass = ((int)query.ExecuteNonQuery()).ToString();
                mcon.Close();
                return pass;
            }
        }
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int year = Int32.Parse(currentYear);
            for (int i = 1950; i <= year; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void createyouraccount_Click(object sender, EventArgs e)
        {
            registration rs = new registration();
            Controls.Add(rs);
            rs.BringToFront();
        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void secure_question_button_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            male = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            female = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((male == true || female == true) && this.secure_question_button.Text != "" && bunifuCustomTextbox2.Text != "" && bunifuCustomTextbox4.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                forget pop = new forget();
                string acess = pop.search(bunifuCustomTextbox4.Text, male);
                if (acess == "0")
                {
                    MessageBox.Show("Check Your Data");
                }
                else
                {
                    password popo = new password(acess);
                    this.Hide();
                    popo.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Check Your Data");
            }
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }
    }
}
