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
    public partial class Kramer : Form
    {
       public double x1, x2, x3, y1, y2, y3, z1, z2, z3, s1, s2, s3, d, dx, dy, dz, x, y ,z ;
       public int i = 0;
        public Kramer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ВВЕДЕННЯ ДАННИХ
            Enrering();
            //підрахунок дельта           
            //ВИВЕДЕННЯ ДЕЛЬТИ
            CountingDelta();
            //підрахунок дельта X           
            //ВИВЕДЕННЯ ДЕЛЬТИ x
           CountingDX();
             //підрахунок дельта y
           
            //ВИВЕДЕННЯ ДЕЛЬТИ y
           CountingDY();
           
            //підрахунок дельта z 
           
            //ВИВЕДЕННЯ ДЕЛЬТИ z 
           CountingDZ();

            //підрахунок X, Y, Z
           CountingX();
           CountingY();
           CountingZ();          
            // vuvedenya vidpovidi
            Reply();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrering();
            i++;
            if (i >= 8)
            {
                Reply();
            } else
            if (i >= 7)
            {
                CountingZ();
            }
            else if (i >= 6)
            {
                CountingY();
            }
            else if (i >= 5)
            {
                CountingX();
            }
            else if (i >= 4)
            {
                CountingDZ();
                textBox46.BackColor = Color.Violet;
                textBox45.BackColor = Color.Violet;
                textBox44.BackColor = Color.Violet;
            }
            else if (i >= 3)
            {
                CountingDY();
                textBox39.BackColor = Color.Violet;
                textBox38.BackColor = Color.Violet;
                textBox37.BackColor = Color.Violet;

            }
            else if (i >= 2)
            {
                CountingDX();
                textBox30.BackColor = Color.Violet;
                textBox31.BackColor = Color.Violet;
                textBox32.BackColor = Color.Violet;
                textBox10.BackColor = Color.Violet;
                textBox11.BackColor = Color.Violet;
                textBox12.BackColor = Color.Violet;

            } else
          
            if (i >= 1)
            {
                CountingDelta();                
            }
          
            
         
          
          
        }
        public void Enrering()
        {
            // ВВЕДЕННЯ ДАННИХ 
            //x1 = Convert.ToDouble(textBox1.Text);
            if(!Double.TryParse(textBox1.Text.Replace('.',','), out x1)) {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox1.Focus();
                return;
            }           
            //x2 = Convert.ToDouble(textBox2.Text);
            if (!Double.TryParse(textBox2.Text.Replace('.', ','), out x2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox2.Focus();
                return;
            }
            //x3 = Convert.ToDouble(textBox3.Text);
            if (!Double.TryParse(textBox3.Text.Replace('.', ','), out x3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox3.Focus();
                return;
            }
            //y1 = Convert.ToDouble(textBox6.Text);
            if (!Double.TryParse(textBox6.Text.Replace('.', ','), out y1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox6.Focus();
                return;
            }
            //y2 = Convert.ToDouble(textBox5.Text);
            if (!Double.TryParse(textBox5.Text.Replace('.', ','), out y2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox5.Focus();
                return;
            }
            //y3 = Convert.ToDouble(textBox4.Text);
            if (!Double.TryParse(textBox4.Text.Replace('.', ','), out y3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox4.Focus();
                return;
            }
            //z1 = Convert.ToDouble(textBox9.Text);
            if (!Double.TryParse(textBox9.Text.Replace('.', ','), out z1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox9.Focus();
                return;
            }
            //z2 = Convert.ToDouble(textBox8.Text);
            if (!Double.TryParse(textBox8.Text.Replace('.', ','), out z2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox8.Focus();
                return;
            }
            //z3 = Convert.ToDouble(textBox7.Text);
            if (!Double.TryParse(textBox7.Text.Replace('.', ','), out z3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox7.Focus();
                return;
            }
            //s1 = Convert.ToDouble(textBox12.Text);
            if (!Double.TryParse(textBox12.Text.Replace('.', ','), out s1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox12.Focus();
                return;
            }
            //s2 = Convert.ToDouble(textBox11.Text);
            if (!Double.TryParse(textBox11.Text.Replace('.', ','), out s2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox11.Focus();
                return;
            }
            //s3 = Convert.ToDouble(textBox10.Text); 
            if (!Double.TryParse(textBox10.Text.Replace('.', ','), out s3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox10.Focus();
                return;
            }
        }
        public void CountingDelta()
        {
            //підрахунок дельта
            d = x1 * y2 * z3 + y1 * z2 * x3 + z1 * x2 * y3 - x1 * z2 * y3 - y1 * x2 * z3 - z1 * y2 * x3;
            //ВИВЕДЕННЯ ДЕЛЬТИ
            textBox13.Text = Convert.ToString(x1);
            textBox14.Text = Convert.ToString(x2);
            textBox15.Text = Convert.ToString(x3);
            textBox18.Text = Convert.ToString(y1);
            textBox17.Text = Convert.ToString(y2);
            textBox16.Text = Convert.ToString(y3);
            textBox21.Text = Convert.ToString(z1);
            textBox20.Text = Convert.ToString(z2);
            textBox19.Text = Convert.ToString(z3);
            textBox22.Text = Convert.ToString(d);
        }
        public void CountingDX()
        {
             //підрахунок дельта X
            dx = s1 * y2 * z3 + y1 * z2 * s3 + z1 * s2 * y3 - s1 * z2 * y3 - y1 * s2 * z3 - z1 * y2 * s3;
            //ВИВЕДЕННЯ ДЕЛЬТИ x
            textBox32.Text = Convert.ToString(s1);
            textBox31.Text = Convert.ToString(s2);
            textBox30.Text = Convert.ToString(s3);
            textBox29.Text = Convert.ToString(y1);
            textBox28.Text = Convert.ToString(y2);
            textBox27.Text = Convert.ToString(y3);
            textBox26.Text = Convert.ToString(z1);
            textBox25.Text = Convert.ToString(z2);
            textBox24.Text = Convert.ToString(z3);
            textBox23.Text = Convert.ToString(dx);
        }
        public void CountingDY()
        {
            //підрахунок дельта y
            dy = x1 * s2 * z3 + s1 * z2 * x3 + z1 * x2 * s3 - x1 * z2 * s3 - s1 * x2 * z3 - z1 * s2 * x3;
            //ВИВЕДЕННЯ ДЕЛЬТИ y
            textBox42.Text = Convert.ToString(x1);
            textBox41.Text = Convert.ToString(x2);
            textBox40.Text = Convert.ToString(x3);
            textBox39.Text = Convert.ToString(s1);
            textBox38.Text = Convert.ToString(s2);
            textBox37.Text = Convert.ToString(s3);
            textBox36.Text = Convert.ToString(z1);
            textBox35.Text = Convert.ToString(z2);
            textBox34.Text = Convert.ToString(z3);
            textBox33.Text = Convert.ToString(dy);
        }
        public void CountingDZ()
        {
            //підрахунок дельта z 
            dz = x1 * y2 * s3 + y1 * s2 * x3 + s1 * x2 * y3 - x1 * s2 * y3 - y1 * x2 * s3 - s1 * y2 * x3;
            //ВИВЕДЕННЯ ДЕЛЬТИ z 
            textBox52.Text = Convert.ToString(x1);
            textBox51.Text = Convert.ToString(x2);
            textBox50.Text = Convert.ToString(x3);
            textBox49.Text = Convert.ToString(y1);
            textBox48.Text = Convert.ToString(y2);
            textBox47.Text = Convert.ToString(y3);
            textBox46.Text = Convert.ToString(s1);
            textBox45.Text = Convert.ToString(s2);
            textBox44.Text = Convert.ToString(s3);
            textBox43.Text = Convert.ToString(dz);
        }
        public void CountingX()
        {
            x = dx / d;
            textBox53.Text = Convert.ToString(dx);
            textBox54.Text = Convert.ToString(d);
            textBox55.Text = Convert.ToString(x);
        }
        public void CountingY()
        {
            y = dy / d;
            textBox58.Text = Convert.ToString(dy);
            textBox57.Text = Convert.ToString(d);
            textBox56.Text = Convert.ToString(y);
        }
        public void CountingZ()
        {
            z = dz / d;
            textBox61.Text = Convert.ToString(dz);
            textBox60.Text = Convert.ToString(d);
            textBox59.Text = Convert.ToString(z);
        }
        public void Reply()
        {
            textBox62.Text = Convert.ToString(x);
            textBox63.Text = Convert.ToString(y);
            textBox64.Text = Convert.ToString(z);
        }
        private void Filling()
        {
            Random rnd = new Random();
            textBox1.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox2.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox3.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox4.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox5.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox6.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox7.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox8.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox9.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox10.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox11.Text = Convert.ToString(rnd.Next(-10, 10));
            textBox12.Text = Convert.ToString(rnd.Next(-10, 10));

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Filling();
              }
    }
}
