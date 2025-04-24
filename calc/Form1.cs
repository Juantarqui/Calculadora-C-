using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void uno_Click(object sender, EventArgs e)
        {
            if(calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "1";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            calcularcaja.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            if (calcularcaja.TextLength == 1) calcularcaja.Text = " ";
            else calcularcaja.Text = calcularcaja.Text.Substring(0, calcularcaja.Text.Length - 1);
        }

        private void dos_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            if (calcularcaja.Text == "0") calcularcaja.Text = " ";
            calcularcaja.Text = calcularcaja.Text + "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            calcularcaja.Text = calcularcaja.Text + "0";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            calcularcaja.Text = calcularcaja.Text + ",";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(calcularcaja.Text);
            calcularcaja.Text = " ";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(calcularcaja.Text);
            calcularcaja.Text = " ";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(calcularcaja.Text);
            calcularcaja.Text = " ";
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(calcularcaja.Text);
            calcularcaja.Text = " ";
        }

        private void igualdad_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(calcularcaja.Text);

            switch (operador)
            {
                case "+":
                    calcularcaja.Text = $"{num1 + num2}";
                    break;
                case "-":
                    calcularcaja.Text = $"{num1 - num2}";
                    break;
                case "*":
                    calcularcaja.Text = $"{num1 * num2}";
                    break;
                case "/":
                    if (num2 == 0) {
                        calcularcaja.Text = "ERROR";
                    }
                    else
                    {
                        calcularcaja.Text = $"{num1 / num2}";
                    }
                        break;
            }
        }
    }
}
