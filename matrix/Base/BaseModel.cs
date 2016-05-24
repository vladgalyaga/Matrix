using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
      public  class BaseModel
    {
        int numberOfDecimals=4;
        public int NumberOfDecimals
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
        bool except = false;

        int minValue = -10, maxValue=20;
        public int MinValue
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
        public int MaxValue
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


        public void massive(string[,] massiveOfString, Matrix matrix)
        {
           
            for (int i = 0; i < matrix.ColumnCount; i++)
                for (int j = 0; j < matrix.RowCount; j++)
                    matrix.Value[i,j] = Audit(massiveOfString[i, j]);

            if (except == true)
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
           
            }
        }
        private double Audit(string s)
        {
            double d;
            if (!Double.TryParse(s.Replace('.', ','), out d))
            {
                except = true;
            }
            return d;
        }



        public void AutoFill(Matrix matrix)
        {
            Random rnd = new Random();
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
