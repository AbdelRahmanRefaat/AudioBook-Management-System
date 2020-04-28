using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace bookista
{
    public partial class registration : UserControl
    {
        bool male = false, female = false;
        class register
        {
            public void registeration(string first, string last, string day, string month, string year, string username, string email, string password, bool male, bool female, string question, string answer)
            {
                string now;
                string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                if (male == true)
                {
                    now = "insert into bookista.login (username, password, data, Gender, First_name, Last_name, email, secure, answer) values('" + username + "','" + password + "','" + (day + "/" + month + "/" + year) + "','" + "male" + "','" + first + "','" + last + "','" + email + "','" + question + "','" + answer.ToLower() + "') ;";
                }
                else
                {
                    now = "insert into bookista.login (username, password, data, Gender, First_name, Last_name, email, secure, answer) values('" + username + "','" + password + "','" + (day + "/" + month + "/" + year) + "','" + "female" + "','" + first + "','" + last + "','" + email + "','" + question + "','" + answer.ToLower() + "') ;";
                }
                MySqlConnection cond = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(now, cond);
                MySqlDataReader read;
                cmd.CommandTimeout = 50;
                cond.Open();
                read = cmd.ExecuteReader();
                cond.Close();
            }
        }
        public registration()
        {
            InitializeComponent();
            registernextpanel.Visible = false;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
            registernextpanel.Visible = true;

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            registernextpanel.Visible = false;
        }

        private void haveanacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            registernextpanel.Visible = false;

        }



        private void comboBox3_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int year = Int32.Parse(currentYear);
            for (int i = 1950; i <= year; i++)
                comboBox3.Items.Add(i);
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            male = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            female = true;
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

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secure_question_button.Text != "" && bunifuCustomTextbox7.Text != "" && bunifuCustomTextbox1.Text != "" && bunifuCustomTextbox2.Text != "" && bunifuCustomTextbox3.Text != "" && bunifuCustomTextbox4.Text != "" && bunifuCustomTextbox5.Text != "" && bunifuCustomTextbox6.Text == bunifuCustomTextbox5.Text)
            {
                register pop = new register();
                pop.registeration(bunifuCustomTextbox1.Text, bunifuCustomTextbox2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, bunifuCustomTextbox3.Text, bunifuCustomTextbox4.Text, bunifuCustomTextbox5.Text, male, female, secure_question_button.Text, bunifuCustomTextbox7.Text);
                success set = new success(0);
                set.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check Your Input Date");
            }
        }

        private void secure_question_button_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void registernextpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomTextbox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
