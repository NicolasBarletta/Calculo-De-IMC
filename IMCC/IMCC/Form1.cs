using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, P,IMC;
            
            A = Convert.ToDouble(textBox1.Text);
            P = Convert.ToDouble(textBox2.Text);
            IMC = P / (A *A);
            textBox3.Text = IMC.ToString("0.00");
           
            if (IMC < 18.49) 
                MessageBox.Show("Situação: Você está abaixo do Peso", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            else if (IMC <= 24.99)  
                    MessageBox.Show("Situação: Você está com Peso na Normalidade", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            else if (IMC < 29.99) 
                MessageBox.Show("Situação: Você está acima do Peso", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else if (IMC < 34.99) 
                MessageBox.Show("Situação: Você está com Obesidade Grau I", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            else if (IMC < 39.99) 
                MessageBox.Show("Situação: Você está com Obesidade Grau II (Severa)", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            else if (IMC > 40) 
                MessageBox.Show("Situação: Você está com Obesidade Grau III (Mórbida)", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

        }
    }
}
