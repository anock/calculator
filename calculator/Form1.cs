using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Calcular_Click(object sender, EventArgs e)
        {

            double num1 = double.Parse(textBox1Num1.Text);
            double num2 = double.Parse(textBox2Num2.Text);
            double resultado;

            if ((string)comboBox1.SelectedItem == "SOMAR") { 
                resultado = num1 + num2;
                label1.Text = resultado.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "DIMINUIR")
            {
                resultado = num1 - num2;
                label1.Text = resultado.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "MULTIPLICAR")
            {
                resultado = num1 * num2;
                label1.Text = resultado.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "DIVIDIR")
            {
                resultado = num1 / num2;
                label1.Text = resultado.ToString();
            }


        }

        private void button1Calcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (label1.Text == "") return;

            else if (e.KeyCode == Keys.Return)
            button1Calcular_Click(button1Calcular, EventArgs.Empty);
            

        }
    }
}
