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
    public partial class Player : UserControl
    {
        public class Run
        {
            public string mem()
            {
                string name = "";
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select * from bookista.login where state != '" + "0" + "';", mcon);
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
            public void save(string name, string autor, string book, string col)
            {
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("insert into bookista.history (name, book, autor, type) values( '" + name + "', '" + book + "', '" + autor + "', '" + col + "');", mcon);
                    MySqlDataReader myread;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public int get(string name)
            {
                int n = 0;
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select * from bookista.book where bookname='" + name + "';", mcon);
                    MySqlDataReader myread;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    while (myread.Read())
                    {
                        n = (int)myread.GetUInt32("num");
                    }
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return n + 1;
            }
            public int Lastpro(string name)
            {
                int n = 0;
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select lastpro('" + name + "');", mcon);
                    mcon.Open();
                    n = (int)query.ExecuteNonQuery();
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return n + 1;
            }
            public void mark(int num, string name)
            {
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("update bookista.book set num= '" + num + "'where bookname='" + name + "';", mcon);
                    MySqlDataReader myread;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void need(string label4, int current, string want)
            {
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("call push('" + label4 + "', '" + current + "', '" + want + "' );", mcon);
                    query.CommandTimeout = 50;
                    mcon.Open();
                    query.ExecuteNonQuery();
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void uplist(ref ListView listView1, string label4, ref List<string> As)
            {
                As.Clear();
                listView1.Items.Clear();
                try
                {
                    string con = "Server=localhost;Database=bookista;User Id=root;Password =;SslMode=none; ";
                    MySqlConnection mcon = new MySqlConnection(con);
                    MySqlCommand query = new MySqlCommand("select * from bookista.bookmarks where bookname='" + label4 + "';", mcon);
                    MySqlDataReader myread;
                    query.CommandTimeout = 50;
                    mcon.Open();
                    myread = query.ExecuteReader();
                    while (myread.Read())
                    {
                        As.Add(myread.GetString("time").ToString());
                        ListViewItem item = new ListViewItem(myread.GetString("name").ToString());
                        listView1.Items.Add(item);
                    }
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void wanted(string retTitle, ref List<Tuple<string, string>> ls, ref List<Tuple<string, string>> author_narrator)
            {
                string constr = "Server=127.0.0.1;Uid=root;Pwd=;Database=bookista;SslMode=none";
                string query = "select * from bookista.book where colname = '" + retTitle + "';";
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                cmd.CommandTimeout = 50;
                con.Open();
                dr = cmd.ExecuteReader();
                string SongPath = "";
                ls.Clear();
                author_narrator.Clear();
                while (dr.Read())
                {
                    string Name = dr.GetString("bookname");
                    SongPath = dr.GetString("path");
                    author_narrator.Add(Tuple.Create(dr.GetString("author"), dr.GetString("narrator")));
                    ls.Add(Tuple.Create(SongPath, Name));
                }
                con.Close();
            }
        }
        List<string> As = new List<string>();
        List<Tuple<string, string>> ls = new List<Tuple<string, string>>();
        List<Tuple<string, string>> author_narrator = new List<Tuple<string, string>>();
        bool playing = true;
        int prevVol = 0, current;
        bool repeat = false, didit = true;
        int indx = 0;
        Timer T;
        public string retTitle;
        public string RetTitle//The Return of the Title of the book The was selected from ListView , Use it to search through Database and Change imgbox pic bla bla and to play the Specific song
        {
            get { return retTitle; }
            set { retTitle = value; }
        }
        public Player()
        {
            InitializeComponent();
            panel2.Visible = false;
            bunifuSlider2.Value = 50;//initializing the volum slider to 50%
            T = new Timer();
            T.Interval = 1000;
            T.Tick += new EventHandler(t_Tick);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play(); playing = true;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause(); playing = false;
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)//aplication exit
        {
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)//maximize and minimize
        {

        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(indx >= ls.Count())
                {
                    indx = 0;
                }
                label3.Text = author_narrator[indx].Item1;
                label6.Text = author_narrator[indx].Item2;
                label4.Text = ls[indx].Item2;
                axWindowsMediaPlayer1.URL = ls[indx].Item1;
                axWindowsMediaPlayer1.Ctlcontrols.play(); 
                indx++;
                Run pop = new Run();
                pop.uplist(ref listView1, label4.Text, ref As);
                didit = true;
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)//Play The Previous Song
        {
            if (List.Items.Count == 0) return;
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            if (indx == 0)
            {
                label3.Text = author_narrator[indx].Item1;
                label6.Text = author_narrator[indx].Item2;
                label4.Text = ls[indx].Item2;
                Run pop = new Run();
                pop.uplist(ref listView1, label4.Text, ref As);
                axWindowsMediaPlayer1.URL = ls[indx].Item1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                indx++;
                List.Update();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.previous();
                indx--;
                label3.Text = author_narrator[indx].Item1;
                label6.Text = author_narrator[indx].Item2;
                label4.Text = ls[indx].Item2;
                Run pop = new Run();
                pop.uplist(ref listView1, label4.Text, ref As);
                axWindowsMediaPlayer1.URL = ls[indx].Item1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                List.Update();
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)///Play The Next Song
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
            if (indx >= ls.Count)
            {
                indx = 0;
                label3.Text = author_narrator[indx].Item1;
                label6.Text = author_narrator[indx].Item2;
                label4.Text = ls[indx].Item2;
                Run pop = new Run();
                pop.uplist(ref listView1, label4.Text, ref As);
                axWindowsMediaPlayer1.URL = ls[indx].Item1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                indx++;
                List.Update();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.next();
                label3.Text = author_narrator[indx].Item1;
                label6.Text = author_narrator[indx].Item2;
                label4.Text = ls[indx].Item2;
                Run pop = new Run();
                pop.uplist(ref listView1, label4.Text, ref As);
                axWindowsMediaPlayer1.URL = ls[indx].Item1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                indx++;
                List.Update();
            }
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)//When you Press over the Sound icon after Mute
        {
            axWindowsMediaPlayer1.settings.volume = bunifuSlider2.Value;
            prevVol = bunifuSlider2.Value;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)// When you Press over the sound icon To Mute
        {
            if (axWindowsMediaPlayer1.settings.volume > 0)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = prevVol;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
     
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)///Playing the minut that the slider bar has been moved to
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuSlider1.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)//Check for Playr is open or not
        {
            if (axWindowsMediaPlayer1.openState == WMPLib.WMPOpenState.wmposMediaOpen)
            {
                bunifuSlider1.MaximumValue = (int)axWindowsMediaPlayer1.currentMedia.duration;
                T.Start();
            }
        }
        void t_Tick(object sender, EventArgs e)//Slider Progression tracker
        {
            bunifuSlider1.Value = (int)this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            int dur = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            double dur2 = axWindowsMediaPlayer1.currentMedia.duration;
            if (dur >= dur2 / 2 && didit == true)
            {
                didit = false;
                Run pop = new Run();
                string name = pop.mem();
                pop.save(name, label3.Text, label4.Text, retTitle);
                int ron = pop.get(label4.Text);
                pop.mark(ron, label4.Text);
            }
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)/// REPEAT
        {
            repeat = !repeat;
            if (repeat)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("loop", false);
            }
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Run pop = new Run();
            pop.wanted(retTitle, ref ls, ref author_narrator);
            for (int i = 0; i < ls.Count; ++i)
            {
                List.Items.Add(ls[i].Item2);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            current = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            panel2.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tm = listView1.FocusedItem.Index;
            string Ntime = As[tm];
            int Ctime = 0;
            for(int i = 0; i < Ntime.Count(); i++)
            {
                Ctime *= 10;
                Ctime += (Ntime[i] - '0');
            }
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Ctime;
        }

        private void pupolar_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AudioPlay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Run pop = new Run();
            string number = pop.Lastpro(label4.Text).ToString();
            bunifuCustomTextbox4.Text = "BookMark" + number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox4.Text != "")
            {
                Run pop = new Run();
                pop.need(label4.Text, current, bunifuCustomTextbox4.Text);
                pop.uplist(ref listView1, label4.Text, ref As);
            }
            panel2.Visible = false;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                List.SelectedIndex = (List.SelectedIndex + 1) % List.Items.Count;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
