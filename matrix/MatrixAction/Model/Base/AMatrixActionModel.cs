using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public delegate void SetMarker(int numberMatrix, int columnCount, int rowCount);

    public delegate void NewMatrix(int numberMatrix, int columnCount, int rowCount);


    public abstract class AMatrixActionModel : BaseModel
    {
        public event SetMarker setMarker;
        public event NewMatrix newMatrix;
       protected Matrix[] m_matrices = new Matrix[3];

        public AMatrixActionModel()
        {

  


            
        }


        public virtual void RecordMAtrix(string[,] dataGridView, int matrixNumber)
        {
            massive(dataGridView, m_matrices[matrixNumber]);

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
    }
}
