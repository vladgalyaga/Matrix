using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public delegate void SetMarker(int numberMatrix, int columnCount, int rowCount);
    public delegate void Except(int numberMatrix, int columnCount, int rowCount);
    public delegate void NewMatrix(int numberMatrix, int columnCount, int rowCount);


    public abstract class AMatrixActionModel : BaseModel
    {
        public event Except exeptionInEntering;
        public event SetMarker setMarker;
        public event NewMatrix newMatrix;
       protected Matrix[] m_matrices = new Matrix[3];

        public AMatrixActionModel()
        {
                       
        }


        public virtual void RecordMAtrix(string[,] dataGridView, int matrixNumber)
        {
            massive(dataGridView,matrixNumber);
        }

        public abstract void AutoFillMatrices();
      
        public double GetValue(int numberMatrix, int columnCount, int rowCount)
        {
                setMarker(numberMatrix, columnCount, rowCount);
                return m_matrices[numberMatrix].Value[columnCount, rowCount];
            
        }

        public abstract string TextAction(int columnNumber, int rowNumber);
        public abstract void Calculation();
        public abstract void CreateMatrices();

        public void CreateMatrix(int numberMatrix, int columnCount, int rowCount)
        {
            m_matrices[numberMatrix] = new Matrix(rowCount, columnCount);
            newMatrix(numberMatrix, columnCount, rowCount);
        }

        public void massive(string[,] massiveOfString, int matrixNumber)
        {
            
            for (int i = 0; i < m_matrices[matrixNumber].ColumnCount; i++)
                for (int j = 0; j < m_matrices[matrixNumber].RowCount; j++)
                    m_matrices[matrixNumber].Value[i, j] = Audit(massiveOfString[i, j], i, j, matrixNumber);

            if (except == true)
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

            }
        }
        private double Audit(string s, int columnNumber, int rowNumber, int numberMatix)
        {
            double d;
            if (!Double.TryParse(s.Replace('.', ','), out d))
            {
                except = true;
                if (exeptionInEntering != null) exeptionInEntering(numberMatix, columnNumber, rowNumber);


            }
            return d;
        }
    }
}
