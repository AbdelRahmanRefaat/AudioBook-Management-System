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

namespace bookista
{
    public partial class profile : UserControl
    {
        public class rockstar
        {
            public string get(string st)
            {
                string n = "";
                string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                MySqlConnection mcon = new MySqlConnection(con);
                MySqlCommand query = new MySqlCommand("select * from bookista.login where state = '" + st + "';", mcon);
                MySqlDataReader myread;
                query.CommandTimeout = 50;
                mcon.Open();
                myread = query.ExecuteReader();
                while (myread.Read())
                {
                    n = myread.GetString("username").ToString();
                }
                return n;
            }
            public void upgrade()
            {
                string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                string now = "call uptosave();";
                MySqlConnection cond = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(now, cond);
                cmd.CommandTimeout = 50;
                try
                {
                    cond.Open();
                    cmd.ExecuteNonQuery();
                    cond.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string Image, name;
        public profile()
        {
            InitializeComponent();
            rockstar popo = new rockstar();
            name = popo.get("1");
            if(name == "")
            {
                name = popo.get("2");
            }
            string myconnection = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none;";
            MySqlConnection myconn = new MySqlConnection(myconnection);
            MySqlCommand selectcommand = new MySqlCommand("select * from bookista.login where username = '" + name + "' ;", myconn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader reader;
            selectcommand.CommandTimeout = 50;
            myconn.Open();
            reader = selectcommand.ExecuteReader();
            while (reader.Read())
            {
                string First = reader.GetString("First_Name");
                label8.Text = First;
                string Last = reader.GetString("Last_name");
                label9.Text = Last;
                string Email = reader.GetString("email");
                label10.Text = Email;
                string Username = reader.GetString("username");
                label11.Text = Username;
                string Gender = reader.GetString("Gender");
                label12.Text = Gender;
                string Birth = reader.GetString("data");
                label13.Text = Birth;
                string ID = reader.GetString("user_id");
                label1.Text = ID;
                Image = reader.GetString("image");
                picturebox.ImageLocation = Image;
                string Secure = reader.GetString("secure");
                label14.Text = Secure;
            }
            myconn.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            rockstar rock = new rockstar();
            rock.upgrade();
            this.Hide();
            Form1 pop = new Form1(false);
            pop.ShowDialog();
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string photo = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                photo = dlg.FileName.ToString();
                picturebox.ImageLocation = photo;
            }
            photo = photo.Replace(@"\", @"\\");
            if (photo != "")
            {
                string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                string now = "update bookista.login set image = '" + photo + "' where username ='" + name + "' ;";
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
                Image = photo;
            }
        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
