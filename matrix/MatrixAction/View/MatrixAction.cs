﻿using System;
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
    public delegate void Calculation();



    public partial class MatrixAction : Form, IView
    {
        public event FillingButtonEventHandler fillingButtonEventHandler;
        public event GetValue getValue;
        public event RecordMatrix recordMatrix;
        public event TextAction textAction;
        public event Calculation calculation;

        bool exc;

        protected DataGridView[] m_dataGridViews = new DataGridView[3];
        protected int q1 = 0, q2 = 0, q11 = 0, q21 = 0;



        public MatrixAction()
        {
            InitializeComponent();
            m_dataGridViews[0] = dataGridView1;
            m_dataGridViews[1] = dataGridView2;
            m_dataGridViews[2] = dataGridView3;
  //          dataGridView1.CellValueChanged
        }

        public void CreatNewGread(int numberMatrix, int columnCount, int rowCount)
        {
            for (int i = 0; i < columnCount; i++)
            {
                m_dataGridViews[numberMatrix].Columns.Add("", "");
            }
            for (int j = 0; j < rowCount; j++)
            {

                m_dataGridViews[numberMatrix].Rows.Add();
            }
            
        }

        private void fillingButton_Click(object sender, EventArgs e)
        {

            fillingButtonEventHandler();


            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < m_dataGridViews[t].Rows.Count; i++)
                {
                    for (int j = 0; j < m_dataGridViews[t].Columns.Count; j++)
                    {

                        m_dataGridViews[t][j, i].Value = getValue(t, j, i);
                    }
                }
            }

        }


        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (exc == false)
            {
                for (int i = 0; i < 2; i++)
                {
                    RecordValue(m_dataGridViews[i], i);
                }
                calculation();

                for (int i = 0; i < dataGridView3.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView3.Rows.Count; j++)
                    {
                        dataGridView3[i, j].Value = getValue(2, i, j);
                    }
                }
                BleachAllGrid();

            }

        }

        private void button1Action_Click(object sender, EventArgs e)
        {
            if(exc ==false)
            OneAction();

        }




        public void OneAction()
        {
            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < m_dataGridViews[t].Rows.Count; i++)
                {
                    for (int j = 0; j < m_dataGridViews[t].Columns.Count; j++)
                    {

                        m_dataGridViews[t].ReadOnly = true;
                    }
                }
            }

            if (q1 == 0 && q2 == 0 && q11 == 0 && q21 == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    RecordValue(m_dataGridViews[i], i);
                }
                calculation();
            }
            BleachAllGrid();

            q11 = q1;
            q21 = q2;

            dataGridView3[q1, q2].Value = Convert.ToString(getValue(2, q1, q2));

            label1.Text = textAction(q1, q2);



            if (q1 < dataGridView3.Columns.Count - 1) { q1++; } else if (q2 < dataGridView3.Rows.Count - 1) { q2++; q1 = 0; }


        }



        private void RecordValue(DataGridView dataGridView, int matrixNumber)
        {
            string[,] s = new string[dataGridView.ColumnCount, dataGridView.Rows.Count];
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    s[i, j] = Convert.ToString(dataGridView[i, j].Value);
                }
            }
            recordMatrix(s, matrixNumber);
        }

        private void BleachAllGrid()
        {
            for (int t = 0; t < m_dataGridViews.Length; t++)
            {
                for (int i = 0; i < m_dataGridViews[t].ColumnCount; i++)
                {
                    for (int j = 0; j < m_dataGridViews[t].Rows.Count; j++)
                    {
                        m_dataGridViews[t][i, j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        public void SetMarker(int numberMatrix, int columnNumber, int rowNumber)
        {
            m_dataGridViews[numberMatrix][columnNumber, rowNumber].Style.BackColor = MainFinalForm.marker;
        }

        public void Except(int numberMatrix, int columnCount, int rowCount)
        {
            m_dataGridViews[numberMatrix][columnCount, rowCount].Style.BackColor = MainFinalForm.ExceptMarker;

            exc = true;
        }
    }
}
