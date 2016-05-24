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
    public partial class Subtraction : Form
    {
        double[,] c;
        int q1 = 0, q2 = 0, q11 = 0, q21 = 0;
        public Subtraction(int rowCount, int colomnCount)
        {
            InitializeComponent();
            for (int i = 0; i < colomnCount; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int j = 0; j < rowCount; j++)
            {

                dataGridView1.Rows.Add();
            }
            ///////////////////////////
            for (int i = 0; i < colomnCount; i++)
            {
                dataGridView2.Columns.Add("", "");
            }
            for (int j = 0; j < rowCount; j++)
            {

                dataGridView2.Rows.Add();
            }
            ////////////////////////////////
            for (int i = 0; i < colomnCount; i++)
            {
                dataGridView3.Columns.Add("", "");
            }
            for (int j = 0; j < rowCount; j++)
            {

                dataGridView3.Rows.Add();
            }
        }
             public void massive()
        {
            double[,] a = new double[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    a[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
            //друга матриця 
            double[,] b = new double[dataGridView2.Columns.Count, dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    b[i, j] = Convert.ToDouble(dataGridView2[i, j].Value);

            c = new double[dataGridView3.Columns.Count, dataGridView3.Rows.Count];
            for (int i = 0; i < dataGridView3.Columns.Count; i++)
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                    c[i, j] = a[i, j] - b[i, j];
        }

             private void button1_Click(object sender, EventArgs e)
             {
                  Random x = new Random();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    int a = x.Next(0, 10);
                    dataGridView1[j, i].Value = a;

                }
            }
             for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    int a = x.Next(0, 10);
                    dataGridView2[j, i].Value = a;
                }
            }
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 massive();
                 for (int i = 0; i < dataGridView1.Columns.Count; i++)
                 {
                     for (int j = 0; j < dataGridView1.Rows.Count; j++)
                     {
                         dataGridView3[i, j].Value = Convert.ToString(c[i, j]);
                     }
                 }
                 dataGridView3.Invalidate();
             }

             private void button3_Click(object sender, EventArgs e)
             {
                 massive();
                 dataGridView3[q11, q21].Style.BackColor = Color.White;
                 dataGridView2[q11, q21].Style.BackColor = Color.White;
                 dataGridView1[q11, q21].Style.BackColor = Color.White;


                 dataGridView3[q1, q2].Style.BackColor = Color.Violet;
                 dataGridView2[q1, q2].Style.BackColor = Color.Violet;
                 dataGridView1[q1, q2].Style.BackColor = Color.Violet;
                 q11 = q1;
                 q21 = q2;
                 dataGridView3[q1, q2].Value = Convert.ToString(c[q1, q2]);
                 label1.Text = Convert.ToString("C" + q1 + q2 + "=(" + dataGridView1[q1, q2].Value + ")-("
                     + dataGridView2[q1, q2].Value) + ")=" + dataGridView3[q1, q2].Value;


                 if (q1 < dataGridView3.Columns.Count - 1) { q1++; } else if (q2 < dataGridView3.Rows.Count - 1) { q2++; q1 = 0; }

             }

        
    }
}
