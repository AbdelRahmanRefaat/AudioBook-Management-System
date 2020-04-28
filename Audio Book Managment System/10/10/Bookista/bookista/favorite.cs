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
    
    public partial class favorite : UserControl
    {
        public class Run
        {
            public void load(string uname, ref ListView favoritelist)
            {
                string server = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                MySqlConnection con = new MySqlConnection(server);
                MySqlCommand qry = new MySqlCommand("select * from bookista.favor where username = '" + uname + "';", con);
                MySqlDataReader reader;
                qry.CommandTimeout = 50;
                con.Open();
                reader = qry.ExecuteReader();
                int count = 0;
                try
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetString("bookname").ToString());
                        item.SubItems.Add(reader.GetString("author").ToString());
                        item.SubItems.Add(reader.GetString("category").ToString());
                        item.SubItems.Add(reader.GetString("Narrator").ToString());
                        favoritelist.Items.Add(item);
                        count += 1;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (count == 0)
                {
                    favoritelist.Items.Clear();
                }
            }
            public void get(ref string target, ref string uname, ref string userid, ref string bookid, ref string bname, ref string narrator, ref string ctgry, ref string authorname, ref bool found)
            {
                string server = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                MySqlConnection con = new MySqlConnection(server);
                MySqlCommand qry = new MySqlCommand("select * from bookista.login where state != '" + "0" + "';", con);
                MySqlCommand qry2 = new MySqlCommand("select * from bookista.book where bookname = '" + target + "';", con);
                MySqlDataReader myread;
                qry.CommandTimeout = 50;
                qry2.CommandTimeout = 50;
                con.Open();
                myread = qry.ExecuteReader();
                try
                {
                    while (myread.Read())
                    {
                        uname = myread.GetString("username").ToString();
                        userid = myread.GetString("user_id").ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                if (target != "")
                {
                    bname = "";
                    con.Open();
                    myread = qry2.ExecuteReader();
                    try
                    {
                        while (myread.Read())
                        {
                            bname = myread.GetString("bookname").ToString().ToLower();
                            bookid = myread.GetString("idbook").ToString();
                            authorname = myread.GetString("author").ToString();
                            ctgry = myread.GetString("colname").ToString();
                            narrator = myread.GetString("narrator").ToString();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (bname == "")
                        found = false;
                    else
                        found = true;
                }
            }
            public void eat(string userid, string bookid, string uname, string bname, string authorname, string narrator, string ctgry)
            {
                string server = "Server = localhost; Database = bookista; User Id = root; Password =; SslMode = none; ";
                string upd = "insert into bookista.favor (user_id, book_id, username, bookname, author, category, Narrator) values('" + userid + "','" + bookid + "','" + uname + "','" + bname + "','" + authorname + "','" + ctgry + "','" + narrator + "') ;";
                MySqlConnection con = new MySqlConnection(server);
                MySqlCommand cmd = new MySqlCommand(upd, con);
                MySqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string userid, uname, bookid, bname, authorname, ctgry, target = "", narrator;
        bool found = true;
        public favorite()
        {
            InitializeComponent();
            Run pop = new Run();
            pop.get(ref target, ref uname, ref userid, ref bookid, ref bname, ref narrator, ref ctgry, ref authorname, ref found);
            pop.load(uname, ref favoritelist);
        }
        private void favoritelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void addbtn_Click(object sender, EventArgs e)
        {

        }
        private void addbtn_Click_1(object sender, EventArgs e)
        {
            target = addtxtbx.Text.ToLower();
            if(target == "")
            {
                MessageBox.Show("Please Enter The Book Name Correct!");
                return ;
            }
            Run pop = new Run();
            pop.get(ref target, ref uname, ref userid, ref bookid, ref bname, ref narrator, ref ctgry, ref authorname, ref found);
            if (!found)
            {
                if (target == "")
                    MessageBox.Show("Please Enter The Name Of The Book Correctly!");
                else
                    MessageBox.Show("Book Not Found!");
            }
            else 
            {
                pop.eat(userid, bookid, uname, bname, authorname, narrator, ctgry);
                favoritelist.Items.Clear();
                pop.load(uname, ref favoritelist);
            }
        }
    }
}
