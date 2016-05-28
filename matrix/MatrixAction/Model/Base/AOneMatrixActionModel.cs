using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
   public abstract class AOneMatrixActionModel:AMatrixActionModel
    {
        public override void AutoFillMatrices()
        {
            AutoFill(m_matrices[0]);
           
        }
    }
}
