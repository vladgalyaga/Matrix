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
    public partial class Add : MatrixAction
    {
        public Add(int rowCount, int columnCount):base(rowCount, columnCount)
        {
          InitializeComponent();
        }
        protected override void OutputAction(Label label)
        {
           // SetCellValue(m_dataGridViews[2], q1, q2, Convert.ToString(m_matrices[2].Value[q1, q2]));


            label.Text = Convert.ToString("C" + q1 + q2 + "=(" + GetCellValue(m_dataGridViews[0], q1, q2) + ")+("
                + GetCellValue(m_dataGridViews[1], q1, q2) + ")=" + GetCellValue(m_dataGridViews[2], q1, q2));
        }
    }
}
