using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Qualifier frm = new Qualifier();
            frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inverse frm = new Inverse();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Summ1 frm = new Summ1();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addition1 frm = new Addition1();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subtraction1 frm = new Subtraction1();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Const1 frm = new Const1();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Transposition1 frm = new Transposition1();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gausa frm = new Gausa();
            frm.Show();
        }
    }
}
