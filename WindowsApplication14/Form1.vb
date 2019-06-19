Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
            Public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imc = 0.00;
            double peso = 0.00;
            double altura = 0.00;

            string resultado = "";

            peso = Convert.ToDouble(textBox1.Text); 
            altura = Convert.ToDouble(textBox2.Text);

            imc = peso / (altura * altura);

            textBox3.Text = imc.ToString();

            if (imc >= 18.5 && imc <= 24.9) 
	        {
                resultado = "Promedio";
	        }

            if (imc >= 25 && imc <= 29.9) 
	        {
                resultado = "Aumentado";
	        }
            if (imc >= 30 && imc <= 34.9) 
	        {
                resultado = "Moderado";
	        }
            if (imc >= 35 && imc <= 39.9) 
	        {
                resultado = "Severo";
	        }

            if (imc >= 40) 
	        {
                resultado = "Muy Severo";
	        }

            MessageBox.Show(resultado);
        }
    }
}
    End Sub
End Class
