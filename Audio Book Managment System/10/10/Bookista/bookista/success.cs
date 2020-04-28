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
    public partial class success : Form
    {
        int flip;
        public success(int ss)
        {
            InitializeComponent();
            flip = ss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (flip == 1)
            {
                Form1 pop = new Form1(true);
                pop.ShowDialog();
            }
            else if(flip == 0)
            {
                Form1 pop = new Form1(false);
                pop.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
