using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace bookista
{
    public partial class Collections : UserControl
    {
        public class Run
        {
            public bool Go(string name, string path, string narrator, string author, string col)
            {
                try
                {
                    string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                    MySqlConnection cond = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand("insert into bookista.book (colname, bookname, author, narrator, path) values('" + col + "','" + name + "','" + author + "','" + narrator + "','" + path + "') ;", cond);
                    MySqlDataReader read;
                    cmd.CommandTimeout = 50;
                    cond.Open();
                    read = cmd.ExecuteReader();
                    cond.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                return true;
            }
            public int find(string col)
            {
                int count = 0;
                try
                {
                    string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                    MySqlConnection cond = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand("select find('" + col + "');", cond);
                    cmd.CommandTimeout = 50;
                    cond.Open();
                    count = (int)cmd.ExecuteNonQuery();
                    cond.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
                return count;
            }
            public void inp(string col)
            {
                try
                {
                    string con = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                    MySqlConnection cond = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand("insert into bookista.collections (name) values('" + col + "') ;", cond);
                    MySqlDataReader read;
                    cmd.CommandTimeout = 50;
                    cond.Open();
                    read = cmd.ExecuteReader();
                    cond.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void Eat(ref ListView CollectionList)
            {
                CollectionList.Items.Clear();
                string constr = "Server=127.0.0.1;Uid=root;Pwd=;Database=bookista;SslMode=none";
                string query = "select * from bookista.collections";
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 50;
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    string colName = dr.GetString("name");
                    CollectionList.Items.Add("", i);
                    CollectionList.Items[i].SubItems.Add(colName);
                    CollectionList.Items.Add(colName);
                    i++;
                }
                con.Close();
            }
        }
        Player Play = new Player();
        string path = "";
        public Collections()
        {
            InitializeComponent();
            Run pop = new Run(); 
            pop.Eat(ref CollectionList);
        }

        private void CollectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = CollectionList.FocusedItem.Index;
            if (CollectionList.SelectedIndices.Count > 0)
            {
                int idx = (int)CollectionList.SelectedIndices[0];
                string Ttitle = (CollectionList.Items[idx].SubItems[0]).ToString();
                int len = Ttitle.Length;
                Ttitle = Ttitle.Substring(18, len - 19);
                Play.retTitle = Ttitle;
                Controls.Add(Play);
                Play.BringToFront();
            }
            else
            {
                string Ttitle = (CollectionList.Items[indx].SubItems[0]).ToString();
                int len = Ttitle.Length;
                Ttitle = Ttitle.Substring(18, len - 19);
                Play.retTitle = Ttitle;
                Play.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(bunifuCustomTextbox4.Text != "" && bunifuCustomTextbox1.Text!="" && bunifuCustomTextbox2.Text != "" && bunifuCustomTextbox3.Text != "" && bunifuCustomTextbox6.Text != "")
            {
                Run pop = new Run();
                if(pop.Go(bunifuCustomTextbox6.Text, bunifuCustomTextbox2.Text, bunifuCustomTextbox1.Text, bunifuCustomTextbox3.Text, bunifuCustomTextbox4.Text) == true)
                {
                    if(pop.find((bunifuCustomTextbox4.Text).ToLower()) <= 0)
                    {
                        pop.inp((bunifuCustomTextbox4.Text).ToLower());
                    }
                    success popo = new success(2);
                    popo.Show();
                }
                pop.Eat(ref CollectionList);
            }
            else
            {
                MessageBox.Show(" Check Your Data, Please! ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Collections_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox3.Clear();
            bunifuCustomTextbox1.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox6.Clear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = true })
            {
                if(OFD.ShowDialog() == DialogResult.OK)
                {
                    path = OFD.FileName.ToString();
                }
            }
            bunifuCustomTextbox2.Text = path;
        }
    }
}
