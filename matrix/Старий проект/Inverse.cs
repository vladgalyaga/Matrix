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
    public partial class Inverse : Form
    {
        public Inverse()
        {
            InitializeComponent();

        }
        double x1, x2, x3, y1, y2, y3, z1, z2, z3, A = 0, r;

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Inverse frm = new Inverse();
            frm.Show();
        }

        double A11, A12, A13, A21, A22, A23, A31, A32, A33;
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                Conferment(); //введення даних
                if (i != 0)
                {
                    A = x1 * y2 * z3 + y1 * z2 * x3 + z1 * x2 * y3 - x1 * z2 * y3 - y1 * x2 * z3 - z1 * y2 * x3;
                    textBox10.Text = Convert.ToString(A);
                    label11.Text = Convert.ToString(A);
                }
            }
            else
                if (i == 2)
            {   //выведеня А 
                textBox11.Text = Convert.ToString(z3);
                textBox12.Text = Convert.ToString(y3);
                textBox13.Text = Convert.ToString(z2);
                textBox14.Text = Convert.ToString(y2);
                A11 = y2 * z3 - y3 * z2;
                textBox16.Text = Convert.ToString(A11);
                label6.Text = "A11";
                //перекрас 
                textBox11.BackColor = Color.Violet;
                textBox12.BackColor = Color.Violet;
                textBox13.BackColor = Color.Violet;
                textBox14.BackColor = Color.Violet;
                textBox24.BackColor = Color.Violet;
                textBox33.BackColor = Color.Violet;
                textBox4.BackColor = Color.Violet;
                textBox5.BackColor = Color.Violet;
                textBox7.BackColor = Color.Violet;
                textBox8.BackColor = Color.Violet;
                textBox42.BackColor = Color.Violet;
                //виведення нижньоъ частини
                textBox24.Text = Convert.ToString(A11);
                textBox33.Text = Convert.ToString(A11);
                textBox42.Text = Convert.ToString(A11 / A);
                label10.Text = Convert.ToString(A11);
            }
            else
                    if (i == 3)
            {
                A12 = x2 * z3 - x3 * z2;
                //выведеня А 
                label6.Text = "A12";
                textBox11.Text = Convert.ToString(z3);
                textBox12.Text = Convert.ToString(x3);
                textBox13.Text = Convert.ToString(z2);
                textBox14.Text = Convert.ToString(x2);
                textBox16.Text = Convert.ToString(A12);
                //перекраска
                textBox6.BackColor = Color.Violet;
                textBox9.BackColor = Color.Violet;
                textBox23.BackColor = Color.Violet;
                textBox30.BackColor = Color.Violet;
                textBox39.BackColor = Color.Violet;

                textBox5.BackColor = Color.White;
                textBox8.BackColor = Color.White;
                textBox42.BackColor = Color.White;
                textBox33.BackColor = Color.White;
                textBox24.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox23.Text = Convert.ToString(A12);
                textBox30.Text = Convert.ToString(A12);
                textBox39.Text = Convert.ToString(A12 / A);
                label10.Text = Convert.ToString(A12);

            }
            else
                        if (i == 4)
            {
                A13 = x2 * y3 - x3 * y2;
                //выведеня А 
                label6.Text = "A13";
                textBox11.Text = Convert.ToString(y3);
                textBox12.Text = Convert.ToString(x3);
                textBox13.Text = Convert.ToString(y2);
                textBox14.Text = Convert.ToString(x2);
                textBox16.Text = Convert.ToString(A13);
                //перекраска
                textBox5.BackColor = Color.Violet;
                textBox8.BackColor = Color.Violet;
                textBox22.BackColor = Color.Violet;
                textBox27.BackColor = Color.Violet;
                textBox36.BackColor = Color.Violet;

                textBox4.BackColor = Color.White;
                textBox7.BackColor = Color.White;
                textBox23.BackColor = Color.White;
                textBox30.BackColor = Color.White;
                textBox39.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox22.Text = Convert.ToString(A13);
                textBox27.Text = Convert.ToString(A13);
                textBox36.Text = Convert.ToString(A13 / A);
                label10.Text = Convert.ToString(A13);
            }
            else
                            if (i == 5)
            {
                A21 = y1 * z3 - y3 * z1;
                //выведеня А 
                label6.Text = "A21";
                textBox11.Text = Convert.ToString(z3);
                textBox12.Text = Convert.ToString(y3);
                textBox13.Text = Convert.ToString(z1);
                textBox14.Text = Convert.ToString(y1);
                textBox16.Text = Convert.ToString(A21);
                //перекраска
                textBox7.BackColor = Color.Violet;
                textBox3.BackColor = Color.Violet;
                textBox2.BackColor = Color.Violet;
                textBox21.BackColor = Color.Violet;
                textBox32.BackColor = Color.Violet;
                textBox41.BackColor = Color.Violet;

                textBox9.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox22.BackColor = Color.White;
                textBox27.BackColor = Color.White;
                textBox36.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox21.Text = Convert.ToString(A21);
                textBox32.Text = Convert.ToString(A21);
                textBox41.Text = Convert.ToString(A21 / A);
                label10.Text = Convert.ToString(A21);
            }
            else
                                if (i == 6)
            {
                A22 = x1 * z3 - x3 * z1;
                //выведеня А 
                label6.Text = "A22";
                textBox11.Text = Convert.ToString(z3);
                textBox12.Text = Convert.ToString(x3);
                textBox13.Text = Convert.ToString(z1);
                textBox14.Text = Convert.ToString(x1);
                textBox16.Text = Convert.ToString(A22);
                //перекраска

                textBox9.BackColor = Color.Violet;
                textBox1.BackColor = Color.Violet;
                textBox20.BackColor = Color.Violet;
                textBox29.BackColor = Color.Violet;
                textBox38.BackColor = Color.Violet;

                textBox2.BackColor = Color.White;
                textBox8.BackColor = Color.White;
                textBox21.BackColor = Color.White;
                textBox32.BackColor = Color.White;
                textBox41.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox20.Text = Convert.ToString(A22);
                textBox29.Text = Convert.ToString(A22);
                textBox38.Text = Convert.ToString(A22 / A);

                label10.Text = Convert.ToString(A22);
            }
            else
                                    if (i == 7)
            {
                A23 = x1 * y3 - x3 * y1;
                //выведеня А 
                label6.Text = "A23";
                textBox11.Text = Convert.ToString(y3);
                textBox12.Text = Convert.ToString(x3);
                textBox13.Text = Convert.ToString(y1);
                textBox14.Text = Convert.ToString(x1);
                textBox16.Text = Convert.ToString(A23);
                //перекраска

                textBox2.BackColor = Color.Violet;
                textBox8.BackColor = Color.Violet;
                textBox19.BackColor = Color.Violet;
                textBox26.BackColor = Color.Violet;
                textBox35.BackColor = Color.Violet;

                textBox3.BackColor = Color.White;
                textBox7.BackColor = Color.White;
                textBox20.BackColor = Color.White;
                textBox29.BackColor = Color.White;
                textBox38.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox19.Text = Convert.ToString(A23);
                textBox26.Text = Convert.ToString(A23);
                textBox35.Text = Convert.ToString(A23 / A);

                label10.Text = Convert.ToString(A23);
            }
            else
                                        if (i == 8)
            {
                A31 = y1 * z2 - z3 * y2;
                //выведеня А 
                label6.Text = "A31";
                textBox11.Text = Convert.ToString(z2);
                textBox12.Text = Convert.ToString(y2);
                textBox13.Text = Convert.ToString(z1);
                textBox14.Text = Convert.ToString(y1);
                textBox16.Text = Convert.ToString(A31);
                //перекраска
                textBox3.BackColor = Color.Violet;
                textBox4.BackColor = Color.Violet;
                textBox5.BackColor = Color.Violet;
                textBox18.BackColor = Color.Violet;
                textBox31.BackColor = Color.Violet;
                textBox40.BackColor = Color.Violet;

                textBox1.BackColor = Color.White;
                textBox9.BackColor = Color.White;
                textBox8.BackColor = Color.White;
                textBox19.BackColor = Color.White;
                textBox26.BackColor = Color.White;
                textBox35.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox18.Text = Convert.ToString(A31);
                textBox31.Text = Convert.ToString(A31);
                textBox40.Text = Convert.ToString(A31 / A);

                label10.Text = Convert.ToString(A31);
            }
            else
                                            if (i == 9)
            {
                A32 = x1 * z2 - x2 * z3;
                //выведеня А 
                label6.Text = "A32";
                textBox11.Text = Convert.ToString(z2);
                textBox12.Text = Convert.ToString(x2);
                textBox13.Text = Convert.ToString(z1);
                textBox14.Text = Convert.ToString(x1);
                textBox16.Text = Convert.ToString(A32);
                //перекраска

                textBox1.BackColor = Color.Violet;
                textBox6.BackColor = Color.Violet;
                textBox17.BackColor = Color.Violet;
                textBox28.BackColor = Color.Violet;
                textBox37.BackColor = Color.Violet;

                textBox2.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox18.BackColor = Color.White;
                textBox31.BackColor = Color.White;
                textBox40.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox17.Text = Convert.ToString(A32);
                textBox28.Text = Convert.ToString(A32);
                textBox37.Text = Convert.ToString(A32 / A);

                label10.Text = Convert.ToString(A32);
            }
            else
                                                if (i == 10)
            {
                A33 = x1 * y2 - x2 * y1;
                //выведеня А 
                label6.Text = "A33";
                textBox11.Text = Convert.ToString(y2);
                textBox12.Text = Convert.ToString(x2);
                textBox13.Text = Convert.ToString(y2);
                textBox14.Text = Convert.ToString(x1);
                textBox16.Text = Convert.ToString(A33);
                //перекраска

                textBox2.BackColor = Color.Violet;
                textBox5.BackColor = Color.Violet;
                textBox15.BackColor = Color.Violet;
                textBox25.BackColor = Color.Violet;
                textBox34.BackColor = Color.Violet;

                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox17.BackColor = Color.White;
                textBox28.BackColor = Color.White;
                textBox37.BackColor = Color.White;
                //виведення нових данних в низу таблицы
                textBox15.Text = Convert.ToString(A33);
                textBox25.Text = Convert.ToString(A33);
                textBox34.Text = Convert.ToString(A33 / A);

                label10.Text = Convert.ToString(A33);
            }
            else
                                                    if (i == 11)
            {

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                textBox11.BackColor = Color.White;
                textBox12.BackColor = Color.White;
                textBox13.BackColor = Color.White;
                textBox14.BackColor = Color.White;
                textBox15.BackColor = Color.White;
                textBox25.BackColor = Color.White;
                textBox34.BackColor = Color.White;

            }

        }
        public void Conferment()
        {
            //x1 = Convert.ToDouble(textBox1.Text);
            //y1 = Convert.ToDouble(textBox2.Text);
            //z1 = Convert.ToDouble(textBox3.Text);
            //z2 = Convert.ToDouble(textBox4.Text);
            //y2 = Convert.ToDouble(textBox5.Text);
            //x2 = Convert.ToDouble(textBox6.Text);
            //z3 = Convert.ToDouble(textBox7.Text);
            //y3 = Convert.ToDouble(textBox8.Text);
            //x3 = Convert.ToDouble(textBox9.Text);

            x1 = Audit(textBox1);
            y1 = Audit(textBox2);
            z1 = Audit(textBox3);
            z2 = Audit(textBox4);
            y2 = Audit(textBox5);
            x2 = Audit(textBox6);
            z3 = Audit(textBox7);
            y3 = Audit(textBox8);
            x3 = Audit(textBox9);
            if (i == 0)
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                
            }
        }
        private double Audit(TextBox textBox)
        {

            if (!Double.TryParse(textBox.Text.Replace('.', ','), out r))
            {                
                textBox.Focus();
                 i = 0;
                return r;
            }
            return r;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox2.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox3.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox4.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox5.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox6.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox7.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox8.Text = Convert.ToString(rnd.Next(-8, 11));
            textBox9.Text = Convert.ToString(rnd.Next(-8, 11));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 11; j++)
            {
                button1_Click(sender, e);
            }
        }
    }
}