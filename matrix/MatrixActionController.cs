using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class MatrixActionController
    {
        MatrixAction m_view;
        AMatrixActionModel m_model;


        public MatrixActionController(int rowCount, int columnCount)
        {
            m_view = new MatrixAction(rowCount, columnCount);
            //m_model = new AMatrixActionModel(rowCount, columnCount);
            
      

            m_view.fillingButtonEventHandler += M_view_fillingButtonEventHandler;
            m_view.getValue += M_view_getValue;
            m_view.recordMatrix += M_view_recordMatrix;
            m_view.textAction += M_view_textAction;

            m_view.Show();

        }
        public void OperationsOnMatrices(AMatrixActionModel model)
        {
            m_model = model;
            m_model.setMarker += M_model_setMarker;
        }

        
        private string M_view_textAction(int columnNumber, int rowNumber)
        {
            return m_model.TextAction(columnNumber, rowNumber);
        }

        private void M_view_recordMatrix(string[,] dataGridView, int matrixNumber)
        {
            m_model.RecordMAtrix(dataGridView, matrixNumber);
        }

        private void M_model_setMarker(int numberMatrix, int columnNumber, int rowNumber)
        {
            m_view.SetMarker(numberMatrix, columnNumber, rowNumber);
        }

        private double M_view_getValue(int numberMatrix, int ColumnCount, int rowCount)
        {
           return m_model.GetValue(numberMatrix, ColumnCount, rowCount);
        }

        private void M_view_fillingButtonEventHandler()
        {
            m_model.AutoFillMatrices();
        }
    }
}
