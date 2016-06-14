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
    public partial class Qualifier : Form
    {
        public Qualifier()
        {
            InitializeComponent();
        }
        int i1 = 0, i2=0, i, k ;
        double x1, x2, x3, y1, y2, y3, z1, z2, z3, s, A, g;
        string S , v;
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float w = pictureBox1.ClientSize.Width;
            float h = pictureBox1.ClientSize.Height;
            float a = w / 2;
            float b = h / 2;
            
            Pen pen1 = new Pen(Color.Green, 2.0f);
            Pen pen2 = new Pen(Color.Orange, 2.0f);
            if (i2 >= 1)
            {
               
                e.Graphics.DrawLine(pen2, 0, h, w, 0);
            }
            if (i2 >= 2)
            {
                e.Graphics.DrawLine(pen2, 0, b, a, 0);
                e.Graphics.DrawLine(pen2, w, h, a, 0);
                e.Graphics.DrawLine(pen2, w, h, 0, b);
            }
            if (i2 >= 3)
            {
                e.Graphics.DrawLine(pen2, w, b, 0, 0);
                e.Graphics.DrawLine(pen2, w, b, a, h);
                e.Graphics.DrawLine(pen2, 0, 0, a, h);
            }

            if (i1 >= 1)
            {
               
                e.Graphics.DrawLine(pen1, 0, 0, w, h);
            }
            if (i1 >= 2)
            {
                e.Graphics.DrawLine(pen1, a, 0, w, b);
                e.Graphics.DrawLine(pen1, a, 0, 0, h);
                e.Graphics.DrawLine(pen1, w,b, 0, h);
            }
            if (i1 >= 3)
            {
                e.Graphics.DrawLine(pen1, w, 0, a, h);
                e.Graphics.DrawLine(pen1, w, 0, 0, b);
                e.Graphics.DrawLine(pen1, 0, b, a, h);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {   pictureBox1.Invalidate();        
            Entering();
            if (g == 1)
            {
                g = 0;
                i1 = 0;
                i2 = 0;
            }
            if (i1 == 3)
                i2++; else
            if (i2 < 3 )
            i1++;
            i = i1 + i2;

            if (i == 1)
            {
                s = x1 * y2 * z3;
                textBox1.BackColor = Color.Violet;
                textBox5.BackColor = Color.Violet;
                textBox7.BackColor = Color.Violet;
            }
            else if (i == 2)
            {
                s = y1 * z2 * x3;
                textBox2.BackColor = Color.Violet;
                textBox4.BackColor = Color.Violet;
                textBox9.BackColor = Color.Violet;

                textBox1.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox7.BackColor = Color.White;
            }
            else if (i == 3)
            {
                s = z1 * x2 * y3;
                textBox3.BackColor = Color.Violet;
                textBox6.BackColor = Color.Violet;
                textBox8.BackColor = Color.Violet;

                textBox2.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox9.BackColor = Color.White;
            }
            else if (i == 4)
            {
                s = x3 * y2 * z1;
                textBox3.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                textBox8.BackColor = Color.White;

                textBox9.BackColor = Color.Violet;
                textBox5.BackColor = Color.Violet;
                textBox3.BackColor = Color.Violet;

                
            }
            else if (i == 5)
            {
                s = x2 * y1 * z3;
                textBox6.BackColor = Color.Violet;
                textBox2.BackColor = Color.Violet;
                textBox7.BackColor = Color.Violet;

                textBox9.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox3.BackColor = Color.White;

                
            
            }
            else if (i == 6)
            {
                s = x1 * z2 * y3;
                textBox1.BackColor = Color.Violet;
                textBox4.BackColor = Color.Violet;
                textBox8.BackColor = Color.Violet;

                textBox6.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox7.BackColor = Color.White;
            }
            if (i > 0)
            {
                S = Convert.ToString(s);
                if (1 < i && i <= 3) v = "+"; if (0 <= i && i <= 3) k = 1;
                else if (i > 3 && i <= 7) { v = "-"; k = -1; }
                if (i <= 6)
                {
                    textBox10.Text += v + "(" + s + ")";
                    A += k * s;

                }
                else if (i == 7)
                    textBox10.Text += "=" + A;
            }
        }    
        public void Entering()
        {
            
            //x1 = Convert.ToDouble(textBox1.Text);
            if (!Double.TryParse(textBox1.Text.Replace('.', ','), out x1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox1.Focus();
                NullAllVariables();
                return;
            }           
            //y1 = Convert.ToDouble(textBox2.Text);   
            if (!Double.TryParse(textBox2.Text.Replace('.', ','), out y1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox2.Focus();
                NullAllVariables();
                return;
            }
            //z1 = Convert.ToDouble(textBox3.Text);
            if (!Double.TryParse(textBox3.Text.Replace('.', ','), out z1))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox3.Focus();
                NullAllVariables();
                return;
            }
            //z2 = Convert.ToDouble(textBox4.Text);
            if (!Double.TryParse(textBox4.Text.Replace('.', ','), out z2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox4.Focus();
                NullAllVariables();
                return;
            }
            //y2 = Convert.ToDouble(textBox5.Text);
            if (!Double.TryParse(textBox5.Text.Replace('.', ','), out y2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox5.Focus();
                NullAllVariables();
                return;
            }
            //x2 = Convert.ToDouble(textBox6.Text);
            if (!Double.TryParse(textBox6.Text.Replace('.', ','), out x2))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                NullAllVariables();
                textBox6.Focus();
                return;
            }
            //z3 = Convert.ToDouble(textBox7.Text);
            if (!Double.TryParse(textBox7.Text.Replace('.', ','), out z3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox7.Focus();
                NullAllVariables();
                return;
            }
            //y3 = Convert.ToDouble(textBox8.Text);
            if (!Double.TryParse(textBox8.Text.Replace('.', ','), out y3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox8.Focus();
                NullAllVariables();
                return;
            }
            //x3 = Convert.ToDouble(textBox9.Text);            
            if (!Double.TryParse(textBox9.Text.Replace('.', ','), out x3))
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox9.Focus();
                NullAllVariables();
                return;
            }              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = 1;
            i1 = 3;
            i2 = 0;
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = 1;
            i1 = 0;
            i2 = 3;
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = 1;
            i1 = 3;
            i2 = 3;
            pictureBox1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox2.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox3.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox4.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox5.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox6.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox7.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox8.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
            textBox9.Text = Convert.ToString(rnd.Next(BaseModel.MinValue, BaseModel.MaxValue) + Math.Round(rnd.NextDouble(), BaseModel.NumberOfDecimals));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1_Click(sender, e);
            button1_Click(sender, e);
            button1_Click(sender, e);
            button1_Click(sender, e);
            button1_Click(sender, e);
            button1_Click(sender, e);
            textBox1.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox8.BackColor = Color.White;

        }
        public void NullAllVariables()
        {
            g = -1;
            i = 1;
            i1 = 0;
            i2 = 0; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NullAllVariables();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;

            pictureBox1.Invalidate();
            textBox10.Text = "";
        }

   

        
    }

}
