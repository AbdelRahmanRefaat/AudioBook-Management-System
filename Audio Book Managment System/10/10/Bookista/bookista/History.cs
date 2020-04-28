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
    public partial class History : UserControl
    {
        public class Run
        {
            public string get(string st)
            {
                string name = "";
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select retname('" + st + "');", mcon);
                    query.CommandTimeout = 50;
                    mcon.Open();
                    name = ((int)query.ExecuteNonQuery()).ToString();
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return name;
            }
            public void eat(string name, ref ListView listView1)
            {
                string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                MySqlConnection mcon = new MySqlConnection(con);
                MySqlCommand query = new MySqlCommand("select * from bookista.history where name = '" + name + "';", mcon);
                MySqlDataReader myread;
                query.CommandTimeout = 50;
                mcon.Open();
                myread = query.ExecuteReader();
                int count = 0;
                try
                {
                    while (myread.Read())
                    {
                        ListViewItem item = new ListViewItem(myread.GetString("book").ToString());
                        item.SubItems.Add(myread.GetString("autor").ToString());
                        item.SubItems.Add(myread.GetString("type").ToString());
                        listView1.Items.Add(item);
                        count += 1;
                    }
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (count == 0)
                {
                    listView1.Items.Clear();
                }
            }
        }
        public History()
        {
            InitializeComponent();
            Run run = new Run();
            string name = run.get("1");
            if(name == "")
            {
                name = run.get("2");
            }
            run.eat(name, ref listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
