using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExercicio30
{
    public partial class Exercicio30 : Form
    {
        public Exercicio30()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResult.Text = "";
            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1 = 0, valor2 = 0, acumulador = 0;
            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            if (valor1 > valor2)
            {
                lblResult.Text = "O segundo número é maior que o primeiro valor!";
            }
            else
            {
                for(int i = valor1; i <= valor2; i++)
                {
                    acumulador += i;
                }
                lblResult.Text = acumulador.ToString(); 
            }
        }
    }
}
