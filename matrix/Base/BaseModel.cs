using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{

   
    public abstract  class BaseModel
    {
       
        static int numberOfDecimals=4;
        static public int NumberOfDecimals
        {
            get
            {
                return numberOfDecimals;
            }

            set
            {
                numberOfDecimals = value;
            }
        }
        protected bool except = false;
        Random rnd = new Random();
        static int minValue = -10, maxValue=20;
        static public int MinValue
        {
            get
            {
                return minValue;
            }

            set
            {
                minValue = value;
            }
        }
        static public int MaxValue
        {
            get
            {
                return maxValue;
            }

            set
            {
                maxValue = value;
            }
        }


      



        public void AutoFill(Matrix matrix)
        {
      
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {

                    matrix.Value[j, i] = rnd.Next(MinValue, MaxValue) + Math.Round( rnd.NextDouble(), NumberOfDecimals);


                }
            }
        }



    }
}
