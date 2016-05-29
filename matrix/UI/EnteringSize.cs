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

        Type m_type;

        public int rowCount, colomnCount;
        public EnteringSize(Type type )
        {
            InitializeComponent();
            numericUpDown1.Value = 3;
            numericUpDown2.Value = 3;

            m_type = type;

            this.Show();

        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            rowCount=Convert.ToInt32(numericUpDown2.Value);
            colomnCount = Convert.ToInt32(numericUpDown1.Value);
            //create(colomnCount, rowCount);
            MatrixActionController mat = new MatrixActionController(typeof(MatrixAction));
            var form = Activator.CreateInstance(m_type, colomnCount, rowCount);
            mat.OperationsOnMatrices((AMatrixActionModel)form);

            
            Close();
        }

       

       
    }
}
