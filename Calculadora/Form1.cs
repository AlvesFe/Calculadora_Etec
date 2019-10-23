using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadoraWd : Form
    {
        public calculadoraWd()
        {
            InitializeComponent();
        }

        double valor1, valor2;
        char operacao;
        string result;

        private void One_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            numBox1.Text = numBox1.Text + "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numBox1.Text);
            operacao = '-';
            numBox1.Clear();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numBox1.Text);
            operacao = 'x';
            numBox1.Clear();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numBox1.Text);
            operacao = '/';
            numBox1.Clear();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (numBox1.Text != "")
            {
                valor2 = double.Parse(numBox1.Text);

                switch (operacao)
                {
                    case '+':
                        result = (valor1 + valor2).ToString();
                        break;
                    case '-':
                        result = (valor1 - valor2).ToString();
                        break;
                    case 'x':
                        result = (valor1 * valor2).ToString();
                        break;
                    case '/':
                        if (valor2 != 0)
                        {
                            result = (valor1 / valor2).ToString();
                        }
                        else
                        {
                            result = "Erro";
                        }
                        break;
                    default:
                        result = "0";
                        break;
                }
                numBox1.Text = valor1.ToString() + operacao.ToString() + valor2.ToString();
                resultadoBox.Text = result.ToString();
            }
            else
            {
                resultadoBox.Text = "Erro";
            }

        }

        private void Onepart_Click(object sender, EventArgs e)
        {
            double onePart = 1 / double.Parse(numBox1.Text);
            numBox1.Text = "1 / " + numBox1.Text;
            resultadoBox.Text = onePart.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            numBox1.Clear();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            numBox1.Clear();
            resultadoBox.Clear();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            double square = Math.Pow(double.Parse(numBox1.Text),2);
            numBox1.Text+="²";
            resultadoBox.Text = square.ToString();
        }

        private void Root_Click(object sender, EventArgs e)
        {
            double square = Math.Sqrt(double.Parse(numBox1.Text));
            numBox1.Text = "√" + numBox1.Text;
            resultadoBox.Text = square.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            double percentual = valor1 * double.Parse(numBox1.Text)/100;
            numBox1.Text = percentual.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numBox1.Text);
            operacao = '+';
            numBox1.Clear();
        }
    }
}
