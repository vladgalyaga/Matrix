using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public class Matrix
    {

        double[,] arr;
        public double[,] Value
        {
            get
            {
                return arr;
            }

            set
            {
                arr = value;
            }
        }

        int rowCount;
        public int RowCount
        {
            get
            {
                return rowCount;
            }

            set
            {
                rowCount = value;
            }
        }

        int columnCount;
        public int ColumnCount
        {
            get
            {
                return columnCount;
            }

            set
            {
                columnCount = value;
            }
        }

        public Matrix(int rowCount, int columnCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Value = new double[columnCount, rowCount];



        }


    }
}
