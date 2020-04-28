using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bookista
{
    public partial class loginscreen : Form
    {
        public class login
        {
            public void reupgrade()
            {
                string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                string now = "update bookista.login set state='" + "0" + "'; ";
                MySqlConnection cond = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(now, cond);
                MySqlDataReader read;
                cmd.CommandTimeout = 50;
                try
                {
                    cond.Open();
                    read = cmd.ExecuteReader();
                    cond.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void upgrade(string username, string password, string st)
            {
                string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                string now = "update bookista.login set state='" + st + "' where username='" + username + "'; ";
                MySqlConnection cond = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(now, cond);
                MySqlDataReader read;
                cmd.CommandTimeout = 50;
                try
                {
                    cond.Open();
                    read = cmd.ExecuteReader();
                    cond.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public bool log(string username, string password)
            {
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select * from bookista.login where username = '" + username + "'AND password = '" + password + "';", mcon);
                    MySqlDataReader myread;
                    query.CommandTimeout = 50;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    int count = 0;
                    while (myread.Read())
                    {
                        count += 1;
                    }
                    mcon.Close();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            public string mem()
            {
                string name = "";
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select * from bookista.login where state = '" + "1" + "';", mcon);
                    MySqlDataReader myread;
                    query.CommandTimeout = 50;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    while (myread.Read())
                    {
                        name = myread.GetString("username").ToString();
                    }
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return name;
            }
        }
        bool test = false;
        public loginscreen()
        {
            InitializeComponent();
            registration1.Visible = false;
            forgetpassword1.Visible = false;
            login rok = new login();
            string ss = rok.mem();
            if(ss != "")
            {
                Form1 pop = new Form1(true);
                this.Hide();
                pop.ShowDialog();
            }
            rok.reupgrade();
        }

        private void forgetpassword_Click(object sender, EventArgs e)
        {
            forgetpassword1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }

       

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text == "  Username")
            {
                username.Text = "";
                username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }

            if ( password.Text == "")
            {
               password.Text = "  Password";
                password.ForeColor = System.Drawing.Color.Silver;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

      

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text == "  Password")
            {
            password.Text = "";
            password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }

            if ( username.Text == "")
            {
                username.Text = "  Username";
                username.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void createyouraccount_Click(object sender, EventArgs e)
        {
            registration1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void remembermecheckbox_OnChange(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void registration1_Load(object sender, EventArgs e)
        {

        }

        private void forgetpassword1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                login pop = new login();
                if (pop.log(username.Text, password.Text) == true)
                {
                    if (test == true)
                    {
                        pop.upgrade(username.Text, password.Text, "1");
                    }
                    else
                    {
                        pop.upgrade(username.Text, password.Text, "2");
                    }
                    success set = new success(1);
                    set.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username Or Password");
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Username Or Password");
            }
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void forgetpassword1_Load_1(object sender, EventArgs e)
        {

        }

        private void rememberme_Click(object sender, EventArgs e)
        {
            if (test == false)
            {
                test = true;
            }
            else
            {
                test = false;
            }
        }

        private void remembermecheckbox_OnChange_1(object sender, EventArgs e)
        {
            if (test == false)
            {
                test = true;
            }
            else
            {
                test = false;
            }
        }

        private void forgetpassword1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
