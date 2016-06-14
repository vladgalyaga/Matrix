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
    public delegate void CreateMatrixActionHAndler(int columnCount, int rowCount);
    public partial class EnteringSize : Form
    {

        Type m_typeModel, m_typeView;
        
        public int rowCount, colomnCount;
        public EnteringSize(Type typeModel, Type typeView )
        {
            InitializeComponent();
            numericUpDown1.Value = 3;
            numericUpDown2.Value = 3;

            m_typeModel = typeModel;
            m_typeView = typeView;
            this.Show();

        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            rowCount=Convert.ToInt32(numericUpDown2.Value);
            colomnCount = Convert.ToInt32(numericUpDown1.Value);
           
            MatrixActionController mat = new MatrixActionController(m_typeView);
            var form = Activator.CreateInstance(m_typeModel, colomnCount, rowCount);
            mat.OperationsOnMatrices((AMatrixActionModel)form);
                        
            Close();
        }

       

       
    }
}
