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
    public partial class Summ : Summ1
    {
        int lic = 0, i1=0, j1=0, i2=0, j2=0;
        double[,] c;
        public Summ(int r1, int r2c1, int c2)
        {
            InitializeComponent();
            
            for (int i = 0; i < r2c1; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int j = 0; j < r1; j++)
            {

                dataGridView1.Rows.Add();
            }



            for (int i = 0; i < c2; i++)
            {
                dataGridView2.Columns.Add("", "");
            }
            for (int j = 0; j < r2c1; j++)
            {

                dataGridView2.Rows.Add();
            }
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dataGridView3.Columns.Add("", "");
            }
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {

                dataGridView3.Rows.Add();
            }
        }    
        public void Zap()
        {
            
            Random x = new Random();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++) { 
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
        public void Product() 
        {

            Massive();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
             
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {

                        dataGridView3[j, i].Value = Convert.ToString(c[j, i]);

                    }
                }
   
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Zap();
        }              
        private void button12_Click(object sender, EventArgs e)
        {
            Product();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            lic++;
            if (lic == 1)
            { 
                Massive();
            }
            dataGridView3[j1, i1].Value = Convert.ToString(c[j1, i1]);

            dataGridView3[j2, i2].Style.BackColor = Color.White;
            
            dataGridView3[j1, i1].Style.BackColor = Color.Violet;

            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            { 
                dataGridView1[j, i2].Style.BackColor = Color.White;
                dataGridView1[j, i1].Style.BackColor = Color.Violet;
              
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2[j2, i].Style.BackColor = Color.White;
                dataGridView2[j1, i].Style.BackColor = Color.Violet;
                
            }
            label5.Text = Convert.ToString("C" + i1 + j1 + "=");

            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                label5.Text += Convert.ToString(" + (" + dataGridView1[k, i1].Value + ")*( " + dataGridView2[j1, k].Value + ")");
            }
            label5.Text += Convert.ToString("=" + dataGridView3[j2, i2].Value);
            j2 = j1;
            i2 = i1;
            if (j1 < dataGridView3.Columns.Count-1)
            {
                j1++;

            }
            else if (i1 < dataGridView3.Rows.Count - 1)
            {
                i1++; j1 = 0; 
            }           
        }
        public void Massive()
        {
            int[,] a = new int[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            //друга матриця 
            int[,] b = new int[dataGridView2.Columns.Count, dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);

            //створення стовбчикыв

          

             c = new double[dataGridView2.Columns.Count, dataGridView1.Rows.Count];

            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    for (int j = 0, k = 0; j < dataGridView1.Rows.Count && k<r2c1-1; j++, k++)
            //    {
            //        c[i,j]=a[i,k]*b[k,j];

            //    }
            //}

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    for (int k = 0; k < dataGridView2.Rows.Count; k++)
                    {
                        c[j, i] += a[k, i] * b[j, k];
                    }
                }
            }
        }
    
    }
}
