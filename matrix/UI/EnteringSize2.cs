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
    public partial class EnteringSize2 : Form
    {  public int r1=3, r2c1=3, c2=3;
        
        public EnteringSize2()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown3.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown2.Value;
        }

        private void Summ1_Load(object sender, EventArgs e)
        {

            
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToInt32(numericUpDown1.Value);
            r2c1 = Convert.ToInt32(numericUpDown2.Value);
            c2 = Convert.ToInt32(numericUpDown4.Value);

            Summ frm = new Summ(r1, r2c1, c2);

            frm.Show();
            Close();

        }







    }
}
