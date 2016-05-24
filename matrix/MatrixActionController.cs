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
        MatrixActionModel m_model;


        public MatrixActionController(int rowCount, int columnCount)
        {
            m_view = new MatrixAction(rowCount, columnCount);
            m_model = new MatrixActionModel(rowCount, columnCount);
            
            m_model.setMarker += M_model_setMarker;

            m_view.fillingButtonEventHandler += M_view_fillingButtonEventHandler;
            m_view.getValue += M_view_getValue;

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
