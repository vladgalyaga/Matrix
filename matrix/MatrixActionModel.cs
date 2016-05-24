using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public delegate void SetMarker(int numberMatrix, int columnCount, int rowCount);


    public abstract class AMatrixActionModel : BaseModel
    {
        public event SetMarker setMarker;


        protected int m_rowCount, m_columnCount;
        protected Matrix[] m_matrices = new Matrix[3];

        public AMatrixActionModel(int rowCount, int columnCount)
        {

            m_rowCount = rowCount;
            m_columnCount = columnCount;

            for (int k = 0; k < m_matrices.Length; k++)
            {

                m_matrices[k] = new Matrix(rowCount, columnCount);


            }
        }

        public void RecordMAtrix(string[,] dataGridView, int matrixNumber)
        {
            massive(dataGridView, m_matrices[matrixNumber]);
        }

        public void AutoFillMatrices()
        {
            AutoFill(m_matrices[0]);
            AutoFill(m_matrices[1]);
        }
        public double GetValue(int numberMatrix, int columnCount, int rowCount)
        {
            setMarker(numberMatrix, columnCount, rowCount);

            return m_matrices[numberMatrix].Value[columnCount, rowCount];
        }
        public abstract string TextAction (int columnNumber, int rowNumber);
        public abstract void Calculation();
    }
}
