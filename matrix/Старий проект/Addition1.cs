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
    public partial class Addition1 : Form
    {
        public int rowCount, colomnCount;
        public Addition1()
        {
            InitializeComponent();
            numericUpDown1.Value = 3;
            numericUpDown2.Value = 3;
        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            rowCount=Convert.ToInt32(numericUpDown2.Value);
            colomnCount = Convert.ToInt32(numericUpDown1.Value);
            

            Addition frm = new Addition(rowCount, colomnCount);

            frm.Show();
        }

       

       
    }
}
