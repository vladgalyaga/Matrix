using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Mul : AMatrixActionModel
    {
        public Mul(int rowCount, int columnCount) : base(rowCount, columnCount)
        {
           
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

        public override string TextAction(int columnNumber, int rowNumber)
        {
            string s;

            s = Convert.ToString("C" + columnNumber + rowNumber + "=");

            for (int k = 0; k < m_matrices[0].ColumnCount; k++)
            {
                s += Convert.ToString(" + (" + m_matrices[0].Value[k, rowNumber] + ")*( " + m_matrices[1].Value[columnNumber, k] + ")");
            }
            s += Convert.ToString("=" + m_matrices[2].Value[columnNumber, rowNumber]);

            return s;
        }
    }
}
