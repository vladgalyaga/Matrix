using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class ConstantModel : ATwoMatricesAction
    {
        int m_rowCount, m_columnCount;
        double m_constant;
        public ConstantModel (int columnCount, int rowCount)
        {
            m_rowCount = rowCount;
            m_columnCount = columnCount;
       //     m_constant = constant;
        }
        

        public override void Calculation()
        {
            
            for (int i = 0; i < m_rowCount; i++)
            {
                for (int j = 0; j < m_columnCount; j++)
                {
                    m_matrices[2].Value[j, i] = m_matrices[0].Value[j, i] * m_matrices[1].Value[1, 1]; 
                }
            }
        }

        public override void CreateMatrices()
        {
            CreateMatrix(0, m_columnCount, m_rowCount);
            CreateMatrix(1, 1, 1);
            CreateMatrix(2, m_columnCount, m_rowCount);
        }

        public override string TextAction(int columnNumber, int rowNumber)
        {
            return Convert.ToString("C" + columnNumber + rowNumber + "=(" + GetValue(0, columnNumber, rowNumber) + ")*("
                + m_constant + ")=" + GetValue(1, columnNumber, rowNumber));
        }
      
    }
}
