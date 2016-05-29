using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public interface IView
    {
        event FillingButtonEventHandler fillingButtonEventHandler;
        event GetValue getValue;
        event RecordMatrix recordMatrix;
        event TextAction textAction;
        event Calculation calculation;

        void CreatNewGread(int numberMatrix, int columnCount, int rowCount);
        void SetMarker(int numberMatrix, int columnNumber, int rowNumber);

        void Show();
    }
}
