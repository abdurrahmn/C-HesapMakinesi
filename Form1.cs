using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double ilksayi;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            islem = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Btntopla_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            islem = "+";
        }

        private void Btncarp_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            islem = "*";
        }

        private void Btnbol_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            islem = "/";
        }

        private void Btnsonuc_Click(object sender, EventArgs e)
        {
            double ikincisayi;
            double sonuc;
            ikincisayi = Convert.ToDouble(textBox1.Text);

            if (islem == "+")
            {
                textBox1.Text = null;
                sonuc = (ilksayi + ikincisayi);
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "-")
            {
                textBox1.Text = null;
                sonuc = (ilksayi - ikincisayi);
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "*")
            {
                textBox1.Text = null;
                sonuc = (ilksayi * ikincisayi);
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "/")
            {if (ikincisayi == 0)
                {
                    textBox1.Text = "bu ne aq";
                }else
                {
                    textBox1.Text = null;
                    sonuc = (ilksayi / ikincisayi);
                    textBox1.Text = Convert.ToString(sonuc);
                    ilksayi = sonuc;
                }
                
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            islem = null;
            ilksayi = 0;
        }
    }
}
