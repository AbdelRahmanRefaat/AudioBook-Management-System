using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookista
{
    public partial class Form1 : Form
    {
        int Hh, Ss, Mm; // for Timer
        public Form1(bool flip)
        {
            InitializeComponent();
            profile2.Visible = false;
            feedback1.Visible = false;
            history1.Visible = false;
            bestsell1.Visible = false;
            search1.Visible = false;
            favorite1.Visible = false;
            collections1.Visible = false;
            home1.Visible = true;

            if (!flip)
            {
                loginscreen ls = new loginscreen();
                ls.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            history1.Visible = false;
            feedback1.Visible = false;
            search1.Visible = false;
            collections1.Visible = false;
            favorite1.Visible = false;
            bestsell1.Visible = false;
            profile2.Visible = true;
            home1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            home1.Visible = true;
            history1.Visible = false;
            bestsell1.Visible = false;
            favorite1.Visible = false;
            profile2.Visible = false;
            search1.Visible = false;
            collections1.Visible = false;
            feedback1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            favorite1.Visible = false;
            history1.Visible = false;
            feedback1.Visible = false;
            profile2.Visible = false;
            bestsell1.Visible = false;
            search1.Visible = false;
            collections1.Visible = true;
            home1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            favorite1.Visible = false;
            feedback1.Visible = false;
            history1.Visible = false;
            profile2.Visible = false;
            search1.Visible = false;
            collections1.Visible = false;
            bestsell1.Visible = true;
            home1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            profile2.Visible = false;
            history1.Visible = false;
            bestsell1.Visible = false;
            feedback1.Visible = false;
            search1.Visible = false;
            collections1.Visible = false;
            favorite1.Visible = true;
            home1.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            bestsell1.Visible = false;
            profile2.Visible = false;
            favorite1.Visible = false;
            search1.Visible = false;
            feedback1.Visible = false;
            collections1.Visible = false;
            history1.Visible = true;
            home1.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
            history1.Visible = false;
            bestsell1.Visible = false;
            favorite1.Visible = false;
            feedback1.Visible = false;
            profile2.Visible = false;
            collections1.Visible = false;
            search1.Visible = true;
            home1.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button12.Height;
            SidePanel.Top = button12.Top;
            history1.Visible = false;
            bestsell1.Visible = false;
            favorite1.Visible = false;
            profile2.Visible = false;
            search1.Visible = false;
            collections1.Visible = false;
            feedback1.Visible = true;
            home1.Visible = false;

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void profile1_Load_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void feedback1_Load(object sender, EventArgs e)
        {

        }

        private void bestsell1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            history1.Visible = false;
            search1.Visible = false;
            bestsell1.Visible = false;
            favorite1.Visible = false;
            feedback1.Visible = false;
            profile2.Visible = false;
            collections1.Visible = false;
            home1.Visible = false;

        }

        private void feedback1_Load_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length > 2)
                {
                    textBox2.Text = textBox2.Text.Substring(0, 2);
                }

                if (textBox2.Text.Length != 0)
                {
                    string Timecontent = textBox2.Text;
                    int M = (int)Int32.Parse(Timecontent);
                    if (M >= 60)
                        textBox2.Text = "59";
                    Mm = Int32.Parse(textBox2.Text);

                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Length > 2)
                {
                    textBox3.Text = textBox3.Text.Substring(0, 2);
                }

                if (textBox3.Text.Length != 0)
                {
                    string Timecontent = textBox3.Text;
                    int S = (int)Int32.Parse(Timecontent);
                    if (S >= 60)
                        textBox3.Text = "59";
                    Ss = Int32.Parse(textBox3.Text);
                }
                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox1.Text) == 0 && Int32.Parse(textBox2.Text) == 0 && Int32.Parse(textBox3.Text) == 0) return;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ss == 0 && Mm == 0 && Hh == 0)
            {
                this.Close();
                Environment.Exit(0);
            }
            if (Ss == 0)
            {
                if (Mm == 0)
                {
                    Hh--;
                    Mm += 59;
                    Ss += 59;
                }
                else
                {
                    Mm--;
                    Ss += 59;
                }
            }
            else
                Ss--;

            textBox1.Text = (Hh < 10 ? "0" + Hh.ToString() : Hh.ToString());
            textBox2.Text = (Mm < 10 ? "0" + Mm.ToString() : Mm.ToString());
            textBox3.Text = (Ss < 10 ? "0" + Ss.ToString() : Ss.ToString());
        }

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 2)
                {
                    textBox1.Text = textBox1.Text.Substring(0, 2);
                }

                if (textBox1.Text.Length != 0)
                {
                    string Timecontent = textBox1.Text;
                    int H = (int)Int32.Parse(Timecontent);
                    if (H >= 24)
                        textBox1.Text = "23";
                    Hh = (int)Int32.Parse(textBox1.Text);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
