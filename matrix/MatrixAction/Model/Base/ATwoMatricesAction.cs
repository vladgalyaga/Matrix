using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
   public abstract  class ATwoMatricesAction:AMatrixActionModel
    {
        public override void AutoFillMatrices()
        {
            AutoFill(m_matrices[0]);
            AutoFill(m_matrices[1]);
        }
    }
}
