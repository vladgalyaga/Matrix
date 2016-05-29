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
    public partial class Constant : Form, IView
    {
        bool except;
        double[,] b;
        int q1 = 0, q2 = 0, q11 = 0, q21 = 0;


        public event FillingButtonEventHandler fillingButtonEventHandler;
        public event GetValue getValue;
        public event RecordMatrix recordMatrix;
        public event TextAction textAction;
        public event Calculation calculation;


        protected DataGridView[] m_dataGridViews = new DataGridView[2];

        public Constant(int rowCount, int colomnCount)
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
            textBox1.Text = Convert.ToString(x.Next(0, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            except = false;
            massive();
            if (except == true) return;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView2[i, j].Value = Convert.ToString(b[i, j]);
                }
            }
            dataGridView2.Invalidate();
        }
        public void massive()
        {
            double[,] a = new double[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    a[i, j] = Audit(Convert.ToString(dataGridView1[i, j].Value));
            if (except == true)
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            //друга матриця 
            double c = Audit(textBox1.Text);
            b = new double[dataGridView2.Columns.Count, dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    b[i, j] = a[i, j] * c;

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            except = false;
            massive();
            if (except == true) return;
            dataGridView2[q11, q21].Style.BackColor = Color.White;
            dataGridView1[q11, q21].Style.BackColor = Color.White;


            textBox1.BackColor = Color.Violet;
            dataGridView2[q1, q2].Style.BackColor = Color.Violet;
            dataGridView1[q1, q2].Style.BackColor = Color.Violet;
            q11 = q1;
            q21 = q2;
            dataGridView2[q1, q2].Value = Convert.ToString(b[q1, q2]);
            label3.Text = Convert.ToString("B" + q1 + q2 + "=(" + dataGridView1[q1, q2].Value + ")*("
                + textBox1.Text + ")=" + b[q1,q2]);


            if (q1 < dataGridView2.Columns.Count - 1) { q1++; } else if (q2 < dataGridView2.Rows.Count - 1) { q2++; q1 = 0; }
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

        public void SetMarker(int numberMatrix, int columnNumber, int rowNumber)
        {
            m_dataGridViews[numberMatrix][columnNumber, rowNumber].Style.BackColor = MainFinalForm.marker;
        }
    }
}
