using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculadora
{
    public partial class calculadoraWd : Form
    {
        public calculadoraWd()
        {
            InitializeComponent();
        }

        double valor1 = 0, valor2, result;
        char operacao;
        bool erro = false, percentClicked = false;

        private void One_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "1";
            resultadoBox.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "2";
            resultadoBox.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "3";
            resultadoBox.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "4";
            resultadoBox.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "5";
            resultadoBox.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "6";
            resultadoBox.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "7";
            resultadoBox.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "8";
            resultadoBox.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "9";
            resultadoBox.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultadoBox.Text.Substring(0, 4) == "Erro")
                {
                    resultadoBox.Clear();
                    numBox1.Clear();
                }
            }
            catch
            {

            }
            numBox1.Text = numBox1.Text + "0";
            resultadoBox.Text += "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "-";
                resultadoBox.Clear();
                operacao = '-';
            }
            catch
            {
                resultadoBox.Text = "0";
                numBox1.Text = "0";
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "-";
                resultadoBox.Clear();
                operacao = '-';
            }

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "x";
                resultadoBox.Clear();
                operacao = 'x';
            }
            catch
            {
                resultadoBox.Text = "0";
                numBox1.Text = "0";
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "x";
                resultadoBox.Clear();
                operacao = 'x';
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "÷";
                resultadoBox.Clear();
                operacao = '÷';
            }
            catch
            {
                resultadoBox.Text = "0";
                numBox1.Text = "0";
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "÷";
                resultadoBox.Clear();
                operacao = '÷';
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (percentClicked == false)
                {
                    valor2 = double.Parse(resultadoBox.Text);
                    resultadoBox.Clear();
                }

                switch (operacao)
                {
                    case '+':
                        result = valor1 + valor2;
                        break;
                    case '-':
                        result = valor1 - valor2;
                        break;
                    case 'x':
                        result = valor1 * valor2;
                        break;
                    case '÷':
                        if (valor2 != 0)
                        {
                            result = valor1 / valor2;
                        }
                        else
                        {
                            erro = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                valor2 = 0;
                numBox1.Text += "0";
                switch (operacao)
                {
                    case '+':
                        result = valor1 + valor2;
                        break;
                    case '-':
                        result = valor1 - valor2;
                        break;
                    case 'x':
                        result = valor1 * valor2;
                        break;
                    case '÷':
                        erro = true;
                        break;
                    default:
                        break;
                }
            }

            if (erro == false)
            {
                numBox1.Text += "=" + result.ToString();
                resultadoBox.Text = result.ToString();
                percentClicked = false;
            }
            else if (erro == true)
            {
                resultadoBox.Text = "Erro";
            }

        }

        private void Onepart_Click(object sender, EventArgs e)
        {
            try
            {
                double onePart = 1 / double.Parse(numBox1.Text);
                numBox1.Text = "1 / " + numBox1.Text;
                resultadoBox.Text = onePart.ToString();
            }
            catch
            {
                resultadoBox.Text = "Erro";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultadoBox.Clear();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            numBox1.Clear();
            resultadoBox.Clear();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            try
            {
                double square = Math.Pow(double.Parse(numBox1.Text), 2);
                numBox1.Text += "²";
                resultadoBox.Text = square.ToString();
            }
            catch
            {
                resultadoBox.Text = "Erro";
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            try
            {
                double square = Math.Sqrt(double.Parse(numBox1.Text));
                numBox1.Text = "√" + numBox1.Text;
                resultadoBox.Text = square.ToString();
            }
            catch
            {
                resultadoBox.Text = "Erro";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                numBox1.Text = numBox1.Text.Substring(0, numBox1.Text.Length - 1);
                resultadoBox.Text = resultadoBox.Text.Substring(0, resultadoBox.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = double.Parse(resultadoBox.Text);
                valor2 = valor1 * (valor2 / 100);
                numBox1.Text += "%";
                percentClicked = true;
            }
            catch
            {
                resultadoBox.Text = "Erro";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "+";
                resultadoBox.Clear();
                operacao = '+';
            }
            catch
            {
                resultadoBox.Text = "0";
                numBox1.Text = "0";
                valor1 = double.Parse(resultadoBox.Text);
                numBox1.Text += "+";
                resultadoBox.Clear();
                operacao = '+';
            }
        }
    }
}
