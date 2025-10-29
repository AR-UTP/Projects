using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables a utilizar:
        string operador = "";
        double num1 = 0;
        double num2 = 0;

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "6";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txt_Screen.Text);
            switch (operador)
            {
                case "+":
                    txt_Screen.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txt_Screen.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txt_Screen.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txt_Screen.Text = $"{num1 / num2}";
                    break;
                case "^":
                    txt_Screen.Text = $"{Math.Pow(num1, num2)}";
                    break;
                case "raiz":
                    txt_Screen.Text = $"{Math.Sqrt(num1)}";
                    break;
                case "| |":
                    txt_Screen.Text = $"{Math.Abs(num1)}";
                    break;
                case "!":
                    if (num1 < 0)
                    {
                        MessageBox.Show("Math ERROR");
                        return;
                    }
                    else
                    {
                        long resultado = 1;
                        for (int i = 1; i <= num1; i++ )
                        {
                            resultado *= i;
                        }
                        txt_Screen.Text = resultado.ToString();
                    }
                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Screen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = ""; 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text.Length == 1)
            {
                txt_Screen.Text = "0";
            }
            else 
            {
                txt_Screen.Text = txt_Screen.Text.Substring(0, txt_Screen.Text.Length - 1);
            }
        }

        private void txt_Screen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            { 
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "4";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0")
            {
                txt_Screen.Text = "";
            }
            txt_Screen.Text = txt_Screen.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Screen.Text = txt_Screen.Text + "0";
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            txt_Screen.Text = txt_Screen.Text + ".";
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        { 
            operador = "+";
            num1 = Convert.ToDouble(txt_Screen.Text);
            txt_Screen.Text = "0";
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            if (txt_Screen.Text == "0" || txt_Screen.Text == "")
            {
                txt_Screen.Text = "-";
            }
            
            else if (txt_Screen.Text == "-")
            {
                return;
            }
            else
            {
                operador = "-";
                num1 = Convert.ToDouble(txt_Screen.Text);
                txt_Screen.Text = "0";
            }
        
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txt_Screen.Text);
            txt_Screen.Text = "0";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txt_Screen.Text);
            txt_Screen.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "raiz";
            num1 = Convert.ToDouble(txt_Screen.Text);
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(txt_Screen.Text);
            txt_Screen.Text = "0";
        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {
            operador = "| |";
            num1 = Convert.ToDouble(txt_Screen.Text);
        }

        private void btn_Factorizacion_Click(object sender, EventArgs e)
        {
            operador = "!";
            num1 = Convert.ToDouble(txt_Screen.Text);
        }
    }
}
