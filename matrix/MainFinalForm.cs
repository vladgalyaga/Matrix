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

    public partial class MainFinalForm : Form
    {
        public static Color marker ;
        public MainFinalForm()
        {
            InitializeComponent();
            numericUpDownNumberOfDecimal.Value = 0;
            numericUpDownMaxValue.Value = 10;
            numericUpDownMinValue.Value = -10;
            marker = Color.Violet;
        }

        private void додаванняToolStripMenuItem_Click(object sender, EventArgs e)
        {


            EnteringSize frm = new EnteringSize(typeof(Add), typeof(MatrixAction));
            //EnteringSize frm = new EnteringSize();
            //frm.create += CreateNewAdd;
        }

        private void відніманняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnteringSize frm = new EnteringSize(typeof(Sub), typeof(MatrixAction));
           // frm.create += CreateNewSub;
        }

        private void множенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatrixActionController mat = new MatrixActionController(typeof(MatrixAction));

            mat.OperationsOnMatrices(new Mul(3, 5, 8));
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            BaseModel.MaxValue = Convert.ToInt32(numericUpDownMaxValue.Value);
            BaseModel.MinValue = Convert.ToInt32(numericUpDownMinValue.Value);
            BaseModel.NumberOfDecimals = Convert.ToInt32(numericUpDownNumberOfDecimal.Value);
          
        }

        private void транспонуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnteringSize frm = new EnteringSize(typeof(Transposit), typeof(TranspositionOfMatrix));
        }
    }
}
