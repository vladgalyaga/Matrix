using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Transposit : AOneMatrixActionModel
    {
        int m_rowCount, m_columnCount;
        public Transposit(int columnCount, int rowCount)
        {

            m_columnCount = columnCount;
            m_rowCount = rowCount;
        }

        public override void Calculation()
        {
            for (int i = 0; i < m_rowCount; i++)
            {
                for (int j = 0; j < m_columnCount; j++)
                {
                    m_matrices[1].Value[i, j] = m_matrices[0].Value[j, i];
                }
            }
        }

        public override void CreateMatrices()
        {
            CreateMatrix(0, m_columnCount, m_rowCount);
            CreateMatrix(1, m_rowCount, m_columnCount);
     
        }

        public override string TextAction(int columnNumber, int rowNumber)
        {
            return Convert.ToString("C" + columnNumber + rowNumber + "=" + GetValue(0, columnNumber, rowNumber) +  "=" + GetValue(1, rowNumber, columnNumber));
        }
        public override void AutoFillMatrices()
        {
            AutoFill(m_matrices[0]);
          
        }

     
    }
}
