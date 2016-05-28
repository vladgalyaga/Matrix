using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Sub : AMatrixActionModel
    {

        int m_rowCount, m_columnCount;
        public Sub(int columnCount, int rowCount)// : base(rowCount, columnCount)
        {
            m_rowCount = rowCount;
            m_columnCount = columnCount;
        }

        public override void Calculation()
        {
            for (int i = 0; i < m_rowCount; i++)
            {
                for (int j = 0; j < m_columnCount; j++)
                {
                    m_matrices[2].Value[j, i] = m_matrices[0].Value[j, i] - m_matrices[1].Value[j, i];
                }
            }
        }

        public override void CreateMatrices()
        {
            CreateMatrix(0, m_columnCount, m_rowCount);
            CreateMatrix(1, m_columnCount, m_rowCount);
            CreateMatrix(2, m_columnCount, m_rowCount);
        }

        public override string TextAction(int columnNumber, int rowNumber)
        {
            return Convert.ToString("C" + columnNumber + rowNumber + "=(" + GetValue(0, columnNumber, rowNumber) + ")-("
              + GetValue(1, columnNumber, rowNumber) + ")=" + GetValue(2, columnNumber, rowNumber));
        }
    }
}
