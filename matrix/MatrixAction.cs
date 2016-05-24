using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public delegate void FillingButtonEventHandler();
    public delegate double GetValue(int numberMatrix, int ColumnCount, int rowCount);
    public delegate void RecordMatrix(string[,] dataGridView, int matrixNumber);
    public delegate string TextAction(int columnNumber, int rowNumber);



    public partial class MatrixAction : Form
    {
        public event FillingButtonEventHandler fillingButtonEventHandler;
        public event GetValue getValue;
        public event RecordMatrix recordMatrix;
        public event TextAction textAction;


        Color marker = Color.Violet;
        int m_rowCount, m_columnCount;

        protected DataGridView[] m_dataGridViews = new DataGridView[3];


        bool except;
        protected int q1 = 0, q2 = 0, q11 = 0, q21 = 0;

        public MatrixAction(int rowCount, int columnCount)
        {
            InitializeComponent();
            m_rowCount = rowCount;
            m_columnCount = columnCount;

            for (int k = 0; k < m_dataGridViews.Length; k++)
            {
                m_dataGridViews[k] = dataGridView1;

                for (int i = 0; i < columnCount; i++)
                {
                    m_dataGridViews[k].Columns.Add("", "");
                }
                for (int j = 0; j < rowCount; j++)
                {

                    m_dataGridViews[k].Rows.Add();
                }
            }

        }

        private void fillingButton_Click(object sender, EventArgs e)
        {

            fillingButtonEventHandler();
           
            
            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                      
                        m_dataGridViews[t][j, i].Value = getValue(t, j, i);
                    }
                }
            }

        }


        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                RecordValue(m_dataGridViews[i], i);
            }


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView3[i, j].Value = getValue(2, j, i);
                }
            }
            dataGridView3.Invalidate();
        }

        private void button1Action_Click(object sender, EventArgs e)
        {
            OneAction();

        }
        private double Audit(string s)
        {
            //y1 = Convert.ToDouble(textBox6.Text);
            double d;
            if (!Double.TryParse(s.Replace('.', ','), out d))
            {

                except = true;

            }
            return d;
        }



        public void OneAction()
        {
            for (int i = 0; i < 2; i++)
            {
                RecordValue(m_dataGridViews[i], i);
            }
            BleachAllGrid();

            q11 = q1;
            q21 = q2;

            //   SetCellValue(dataGridView3, q1, q2, Convert.ToString(m_matrices[2].Value[q1, q2]));

            dataGridView3[q1, q2].Value = Convert.ToString(getValue(2, q1, q2));

            label1.Text = textAction(q1,q2);
            //label1.Text = Convert.ToString("C" + q1 + q2 + "=(" + GetCellValue(dataGridView1, q1, q2) + ")+("
            //    + GetCellValue(dataGridView1, q1, q2) + ")=" + GetCellValue(dataGridView3, q1, q2));


            if (q1 < dataGridView3.Columns.Count - 1) { q1++; } else if (q2 < dataGridView3.Rows.Count - 1) { q2++; q1 = 0; }


        }
     //   protected virtual void OutputAction(Label label) { }


        private void RecordValue(DataGridView dataGridView, int matrixNumber)
        {
            string[,] s = new string[m_columnCount, m_rowCount];
            for (int i = 0; i < m_columnCount; i++)
            {
                for (int j = 0; j < m_rowCount; j++)
                {
                    s[i, j] = Convert.ToString(dataGridView[i, j].Value);
                }
            }

           recordMatrix(s, matrixNumber);
        }

        //private void RecordValue(DataGridView dataGridView, Matrix matrix)
        //{
        //    string[,] s = new string[m_columnCount, m_rowCount];
        //    for (int i = 0; i < m_columnCount; i++)
        //    {
        //        for (int j = 0; j < m_rowCount; j++)
        //        {
        //            s[i, j] = Convert.ToString(dataGridView[i, j].Value);
        //        }
        //    }

        //    massive(s, matrix);
        //}
        private void BleachAllGrid()
        {
            for (int t = 0; t < m_dataGridViews.Length; t++)
            {
                for (int i = 0; i < m_columnCount; i++)
                {
                    for (int j = 0; j < m_rowCount; j++)
                    {
                        m_dataGridViews[t][i, j].Style.BackColor = Color.White;
                    }
                }
            }
        }


        public void SetMarker(int numberMatrix, int columnNumber, int rowNumber)
        {
            m_dataGridViews[numberMatrix][columnNumber, rowNumber].Style.BackColor = marker;
        }
       
        //protected string GetCellValue(DataGridView dataGridView, int columnNumber, int rowNumber)
        //{
        //    dataGridView[columnNumber, rowNumber].Style.BackColor = marker;

        //    return Convert.ToString(dataGridView1[columnNumber, rowNumber].Value);

        //}
        //protected void SetCellValue(DataGridView dataGridView, int columnNumber, int rowNumber, string value)
        //{
        //    dataGridView[columnNumber, rowNumber].Style.BackColor = marker;

        //    dataGridView[columnNumber, rowNumber].Value = value;

        //}
    }
}
