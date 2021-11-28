using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExercicio7
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumCarro.Text = "";
            txtSalario.Text = "";
            txtValorCarro.Text = "";
            txtVendas.Text = "";
            lblResultado.Text = "";
            txtNumCarro.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario = 0.0, valorPorCarro = 0.0, totalVendas = 0.0, salarioFinal = 0.0;
            int numCarros = 0;

            salario = double.Parse(txtSalario.Text);
            valorPorCarro = double.Parse(txtValorCarro.Text);
            totalVendas = double.Parse(txtVendas.Text);
            numCarros = int.Parse(txtNumCarro.Text);

            salarioFinal = salario + (valorPorCarro * numCarros) + ((totalVendas * 5.0) / 100.0);
            lblResultado.Text  = salarioFinal.ToString();
        }
    }
}
