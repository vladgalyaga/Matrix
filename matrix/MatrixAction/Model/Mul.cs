using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Mul : AMatrixActionModel
    {
        int m_m1rowCount, m_m1ColumnCount_m2RowCount, m_m2ColumnCount;
        public Mul(int rowCount, int columnCountM1_rowCountM2, int matrix2ColumnCount) : base()
        {
            m_m1rowCount = rowCount;
            m_m1ColumnCount_m2RowCount = columnCountM1_rowCountM2;
            m_m2ColumnCount = matrix2ColumnCount;
            //m_matrices[0] = new Matrix(rowCount, columnCountM1_rowCountM2);
            //m_matrices[1] = new Matrix(columnCountM1_rowCountM2, matrix2ColumnCount);
            //m_matrices[2] = new Matrix(rowCount, matrix2ColumnCount);
        }

        public override void Calculation()
        {
            for (int i = 0; i < m_matrices[0].RowCount; i++)
            {
                for (int j = 0; j < m_matrices[1].ColumnCount; j++)
                {
                    for (int k = 0; k < m_matrices[1].RowCount; k++)
                    {
                        m_matrices[2].Value[j, i] += m_matrices[0].Value[k, i] * m_matrices[1].Value[j, k];
                    }
                }
            }
        }

        public override void CreateMatrices()
        {
            CreateMatrix(0, m_m1ColumnCount_m2RowCount, m_m1rowCount);
            CreateMatrix(1, m_m2ColumnCount, m_m1ColumnCount_m2RowCount);
            CreateMatrix(2, m_m2ColumnCount, m_m1rowCount);
        }

        public override string TextAction(int columnNumber, int rowNumber)
        {
            string s;

            s = Convert.ToString("C" + columnNumber + rowNumber + "=");

            for (int k = 0; k < m_matrices[0].ColumnCount; k++)
            {
                // s += Convert.ToString(" + (" + m_matrices[0].Value[k, rowNumber] + ")*( " + m_matrices[1].Value[columnNumber, k] + ")");
                s += Convert.ToString(" + (" + GetValue(0,k,rowNumber) + ")*( " + GetValue(1,columnNumber,k) + ")");

            }
            //    s += Convert.ToString("=" + m_matrices[2].Value[columnNumber, rowNumber]);
            s += Convert.ToString("=" + GetValue(2,columnNumber,rowNumber));
            return s;
        }
    }
}
