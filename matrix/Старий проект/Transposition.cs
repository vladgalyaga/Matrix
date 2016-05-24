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
    public partial class Transposition : Form
    {
        int[,] b;
        int q1 = 0, q2 = 0, q11 = 0, q21 = 0;
        public Transposition(int rowCount, int colomnCount)
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
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView2.Columns.Add("", "");
            }
            for (int j = 0; j < colomnCount; j++)
            {

                dataGridView2.Rows.Add();
            }
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
          
        }
         public void massive()
        {
            int[,] a = new int[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            //друга матриця 
             b = new int[dataGridView2.Columns.Count, dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    b[i, j] = a[j,i];
        }

         private void button2_Click(object sender, EventArgs e)
         {
             massive();
             for (int i = 0; i < dataGridView2.Columns.Count; i++)
             {
                 for (int j = 0; j < dataGridView2.Rows.Count; j++)
                 {
                     dataGridView2[i, j].Value = Convert.ToString(b[i, j]);
                 }
             }
             dataGridView2.Invalidate();
         }

         private void button3_Click(object sender, EventArgs e)
         {
             massive();
            
             dataGridView2[q11, q21].Style.BackColor = Color.White;
             dataGridView1[q21,q11 ].Style.BackColor = Color.White;


            
             dataGridView2[q1, q2].Style.BackColor = Color.Violet;
             dataGridView1[q2, q1].Style.BackColor = Color.Violet;
             q11 = q1;
             q21 = q2;
             dataGridView2[q1, q2].Value = Convert.ToString(b[q1, q2]);
            


             if (q1 < dataGridView2.Columns.Count - 1) { q1++; } else if (q2 < dataGridView2.Rows.Count - 1) { q2++; q1 = 0; }
         }

        

            
    }
}
