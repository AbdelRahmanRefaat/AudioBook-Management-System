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
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
            string s=richTextBox1.Text;
            MySqlConnection con = new MySqlConnection(server);
            string cmdbyname = "call search_by_name( '" + s + "' );";
            string cmdbyauthor = "call search_by_author( '" + s + "' );";
            string cmdbynarrator = "call search_by_narrator( '" + s + "' );";
            string cmdbycategory = "call search_by_category( '" + s + "' );";
            MySqlCommand qbyname= new MySqlCommand(cmdbyname,con);
            MySqlCommand qbyauthor = new MySqlCommand(cmdbyauthor, con);
            MySqlCommand qbynarrator = new MySqlCommand(cmdbynarrator, con);
            MySqlCommand qbycategory = new MySqlCommand(cmdbycategory, con);
            MySqlDataReader readerbyname, readerbyauthor, readerbynarrator, readerbycategory;
            qbyauthor.CommandTimeout = 50;
            qbyname.CommandTimeout = 50;
            qbynarrator.CommandTimeout = 50;
            qbycategory.CommandTimeout = 50;
            con.Open();
            list.Items.Clear();
            int cnt = 0;
            try
            {
                if (byname.Checked)
                {
                    readerbyname = qbyname.ExecuteReader();
                    while (readerbyname.Read())
                    {
                        ListViewItem item = new ListViewItem(readerbyname.GetString("bookname").ToString());
                        item.SubItems.Add(readerbyname.GetString("author").ToString());
                        item.SubItems.Add(readerbyname.GetString("narrator").ToString());
                        item.SubItems.Add(readerbyname.GetString("colname").ToString());
                        list.Items.Add(item);
                        cnt += 1;
                    }
                }
                else if (byauthor.Checked)
                {
                    readerbyauthor = qbyauthor.ExecuteReader();
                    while (readerbyauthor.Read())
                    {
                        ListViewItem item = new ListViewItem(readerbyauthor.GetString("bookname").ToString());
                        item.SubItems.Add(readerbyauthor.GetString("author").ToString());
                        item.SubItems.Add(readerbyauthor.GetString("narrator").ToString());
                        item.SubItems.Add(readerbyauthor.GetString("colname").ToString());
                        list.Items.Add(item);
                        cnt += 1;
                    }
                }
                else if (bynarrator.Checked)
                {
                    readerbynarrator = qbynarrator.ExecuteReader();
                    while (readerbynarrator.Read())
                    {
                        ListViewItem item = new ListViewItem(readerbynarrator.GetString("bookname").ToString());
                        item.SubItems.Add(readerbynarrator.GetString("author").ToString());
                        item.SubItems.Add(readerbynarrator.GetString("narrator").ToString());
                        item.SubItems.Add(readerbynarrator.GetString("colname").ToString());
                        list.Items.Add(item);
                        cnt += 1;
                    }
                }
                else if(bycategory.Checked)
                {
                    readerbycategory = qbycategory.ExecuteReader();
                    while (readerbycategory.Read())
                    {
                        ListViewItem item = new ListViewItem(readerbycategory.GetString("bookname").ToString());
                        item.SubItems.Add(readerbycategory.GetString("author").ToString());
                        item.SubItems.Add(readerbycategory.GetString("narrator").ToString());
                        item.SubItems.Add(readerbycategory.GetString("colname").ToString());
                        list.Items.Add(item);
                        cnt += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(cnt==0)
            {
                MessageBox.Show("No Results Found");
            }
            con.Close();
        }

        private void byauthor_CheckedChanged(object sender, EventArgs e)
        {
            if (byauthor.Checked)
            {
                byname.Checked = false;
                bycategory.Checked = false;
                bynarrator.Checked = false;
            }
        }

        private void byname_CheckedChanged(object sender, EventArgs e)
        {
            if (byname.Checked)
            {
                byauthor.Checked = false;
                bycategory.Checked = false;
                bynarrator.Checked = false;
            }
        }

        private void bynarrator_CheckedChanged(object sender, EventArgs e)
        {
            if (bynarrator.Checked)
            {
                byauthor.Checked = false;
                byname.Checked = false;
                bycategory.Checked = false;
            }
        }

        private void bycategory_CheckedChanged(object sender, EventArgs e)
        {
            if (bycategory.Checked)
            {
                byauthor.Checked = false;
                byname.Checked = false;
                bynarrator.Checked = false;
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
