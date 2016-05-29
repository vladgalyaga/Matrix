using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class MatrixActionController
    {
        IView m_view;
        AMatrixActionModel m_model;


        public MatrixActionController(Type type)
        {
           // m_view = new MatrixAction();

          
             m_view = (IView)Activator.CreateInstance(type);
        


            m_view.fillingButtonEventHandler += M_view_fillingButtonEventHandler;
            m_view.getValue += M_view_getValue;
            m_view.recordMatrix += M_view_recordMatrix;
            m_view.textAction += M_view_textAction;
            m_view.calculation += M_view_calculation;
            m_view.Show();

        }

        private void M_view_calculation()
        {
            m_model.Calculation();
        }

        public void OperationsOnMatrices(AMatrixActionModel model)
        {
            m_model = model;
            m_model.setMarker += M_model_setMarker;
            m_model.newMatrix += M_model_newMatrix;
            m_model.CreateMatrices();
        }

        private void M_model_newMatrix(int numberMatrix, int columnCount, int rowCount)
        {
            m_view.CreatNewGread(numberMatrix, columnCount, rowCount);
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
