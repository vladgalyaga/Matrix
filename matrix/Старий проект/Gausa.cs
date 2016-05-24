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
    public partial class Gausa : Form
    {
        
      //  TextBox oldBox, oldBox1;
        int i = 0;
        bool fault;
        double x, y, z;
        TextBox[] textBoxs = new TextBox[10];
        TextBox[] boxs1;
        TextBox[] boxs0;
        TextBox[] boxs2;
        TextBox[] boxs3;
        double[] variable = new double[12];
        double[] variable1 = new double[12];
        double[] variable2  = new double[12];
        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
             
            textBoxX1.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxX2.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxX3.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxY1.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxY2.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxY3.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxZ1.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxZ2.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxZ3.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxS1.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxS2.Text = Convert.ToString(rnd.Next(-8, 11));
            textBoxS3.Text = Convert.ToString(rnd.Next(-8, 11));
        }
         
        
        public Gausa()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Record();
                Act1();
                Act2();
            }
            if (i<12)
            {
                boxs1[i].Text = boxs0[i].Text;
                Painting(boxs0[i], boxs1[i]);
                labelText.Text = boxs0[i].Text + "=" + boxs1[i].Text;
            } 
            if (12 <= i && i<24)
            {
                int a = i % 12;
                boxs2[a].Text = Convert.ToString(variable1[a]);
                    labelText.Text = boxs1[a].Text + "=" + boxs2[a].Text;
                    Painting(boxs2[a], boxs1[a]);
                if (a > 3)
                {
                    Painting(boxs1[a / 4 * 4], boxs1[a % 4], Color.Green, false);
                    Painting(boxs1[0], boxs1[a], Color.Yellow, false);
                    //labelText.Text = boxs1[a / 4 * 4].Text + "*" + boxs1[a % 4].Text
                    //        + "-" + boxs1[0].Text + "*" + boxs1[a].Text + "=" + boxs2[a].Text;
                    labelText.Text = boxs1[a / 4 * 4].Text + "*" + SS(boxs1, a % 4) + "-" +
                    SS(boxs1, 0) + "*" + SS(boxs1, a) + "=" + boxs2[a].Text;

                }
            }
            if(24<=i&&i<36)
            {
                int a = i % 24;
                boxs3[a].Text = Convert.ToString(variable2[a]);
                Painting(boxs3[a], boxs2[a]);
                labelText.Text = boxs2[a].Text + "=" + boxs3[a].Text;
                if (a > 8)
                {
                    Painting(boxs2[9], boxs2[a - 4], Color.Green, false);
                    Painting(boxs2[5], boxs2[a], Color.Yellow, false);
                    labelText.Text = boxs2[9].Text + "*" + SS(boxs2, a - 4) + "-" +
                    SS(boxs2, 5) + "*" + SS(boxs2, a) + "=" + boxs3[a].Text;
                }
            }
            if (i == 36)
            {
                Painting(boxs3[11], boxs3[10]);
                z = variable2[11] / variable2[10];
                textBoxZ.Text =Convert.ToString(z);
                labelText.Text = "Z = " + boxs3[11].Text + "/" + boxs3[10].Text + "=" + Convert.ToString(z);
            }
            if (i == 37)
            {

                Painting(textBoxY, textBoxY);
                Painting(textBoxZ, boxs3[6], Color.Blue, false);
                Painting(boxs3[7], boxs3[7], Color.Orange, false);
                Painting(boxs3[5], boxs3[5], Color.Green, false);
                y = (variable2[7]-( z*variable2[6]))/variable2[5] ;
                textBoxY.Text = Convert.ToString(y);
                labelText.Text = "Y = (" + boxs3[7].Text + " - " + textBoxZ.Text + " * " + boxs3[6].Text+") / " 
                    + boxs3[5].Text + " = " + y;
            }
            if (i == 38)
            {
                
                Painting(textBoxX, textBoxX);
                Painting(textBoxZ, boxs3[2], Color.Blue, false);
                Painting(textBoxY, boxs3[1], Color.Orange, false);
                Painting(boxs3[3], boxs3[3], Color.Green, false);
                Painting(boxs3[0], boxs3[0], Color.Yellow, false);
                x = (variable2[3] - z * variable2[2] - y * variable2[1]) / variable2[0];
                textBoxX.Text = Convert.ToString(x);
                labelText.Text = "X = (" + boxs3[3].Text + " - " + textBoxY.Text + " * " + boxs3[1].Text +" - "
                    + boxs3[2].Text + " * " + textBoxZ.Text +") / "
                    + boxs3[0].Text + " = " + x;
            }
            if (i == 39)
            {
                labelText.Text = "";
                ClearColor();
            }
            i++;


            if (fault == true)
            {
                MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                i = 0;
                
                textBox00.BackColor = Color.White;
                textBoxX1.BackColor = Color.White;
                textBox00.Text = "";
                textBoxX1.Text = "";
                return;
            }
        }
        private void Painting(TextBox box, TextBox box1)
        {
            Painting(box, box1, Color.Violet, true);
            
        }
        private void Painting(TextBox box, TextBox box1, Color color, bool clear)
        {
            if(clear == true)
            ClearColor();
            
            box.BackColor = color;
            box1.BackColor = color;
          
            for (int j = 0; j < 10; j++)
            {
                if (textBoxs[j] == null)
                {
                    textBoxs[j] = box;
                    textBoxs[j + 1] = box1;
                    break;
                }
            }
        }
        private double Audit(TextBox textBox)
        {
            
            double d;
            string s = Convert.ToString(textBox.Text);
            if (!Double.TryParse(s.Replace('.', ','), out d))
            {
                //MessageBox.Show("не вірні початкові дані", "помилка", MessageBoxButtons.OK,
                //    MessageBoxIcon.Exclamation);
                fault = true;
                textBox.Focus();
            }
            return d;
        }
        private void Record()
        {
            fault = false;
           variable[0] = Audit(textBoxX1);
            variable[4] = Audit(textBoxX2);
            variable[8] = Audit(textBoxX3);
            variable[1] = Audit(textBoxY1);
            variable[5] = Audit(textBoxY2);
            variable[9] = Audit(textBoxY3);
            variable[2] = Audit(textBoxZ1);
            variable[6] = Audit(textBoxZ2);
            variable[10] = Audit(textBoxZ3);
            variable[3] = Audit(textBoxS1);
            variable[7] = Audit(textBoxS2);
            variable[11] = Audit(textBoxS3);
                       
            
             boxs1 = new TextBox[]{
                 textBox00, textBox10, textBox20, textBox30,
                 textBox01, textBox11,textBox21,textBox31,
                 textBox02, textBox12, textBox22, textBox32};
            boxs0 = new TextBox[]
            {
                textBoxX1, textBoxY1, textBoxZ1, textBoxS1,
                textBoxX2, textBoxY2, textBoxZ2, textBoxS2,
                textBoxX3, textBoxY3, textBoxZ3, textBoxS3
            };
            boxs2 = new TextBox[]{
                 textBox4, textBox5, textBox6, textBox1,
                 textBox7, textBox8,textBox9,textBox2,
                 textBox13, textBox14, textBox15, textBox3};
            boxs3 = new TextBox[]{
                 textBox19, textBox23, textBox24, textBox16,
                 textBox25, textBox26,textBox27,textBox17,
                 textBox28, textBox29, textBox33, textBox18};
        }
        private void Act1()
        {

            for (int j = 0; j < 12; j++)
            {
                if (j >= 4)
                {
                    variable1[j] = variable[j / 4 * 4] * variable[j % 4] - variable[0] * variable[j];
                }
                else variable1[j] = variable[j];
                   
            }
        }
        private void Act2()
        {
            for (int j = 0; j < 12; j++)
            {
                if (j >= 9)
                {
                    variable2[j] = variable1[9] * variable1[j - 4] - variable1[5] * variable1[j];
                }
                else variable2[j] = variable1[j];
            }
            
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            ClearColor();
           
            fault=false;
            x = 0;
            y = 0;
            z =0;
            ClearTextBox(boxs1);
            ClearTextBox(boxs0);
            ClearTextBox(boxs2);
            ClearTextBox(boxs3);
            ClearVariable(variable);
            ClearVariable(variable1);
            ClearVariable(variable2);
            labelText.Text = "";
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxZ.Text = "";
            i = 0;
        }

        private void ClearColor()
        {
            for (int j = 0; j < 10; j++)
            {
                if (textBoxs[j] != null)
                {
                    textBoxs[j].BackColor = Color.White;
                    textBoxs[j]= null;
                }
                else return;
            }
        }
        private string SS(TextBox[] boxs, int a) 
           
        {
            double d = Audit(boxs[a]);
            string s;
            if (d < 0)
            {
                s = "(" + boxs[a].Text + ")";
            }
            else
            {
                s = boxs[a].Text;
            }
            return s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           for(int j = 0; j<40; j++)
            {
                if (fault == true) return;
                    button1_Click(sender, e);
            }
        }

        private void ClearTextBox(TextBox[] boxis)
        {
            if (i != 0)
            {
                for (int j = 0; j < 12; j++)
                {

                    boxis[j].Text = "";
                }
            }
        }
        private void ClearVariable(double[] var)
        {

            for (int j = 0; j < 12; j++)
            {
                var[j] = 0;
            }
        }
    }
}
