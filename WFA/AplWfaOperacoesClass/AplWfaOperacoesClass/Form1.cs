using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClOperacoes;

namespace AplWfaOperacoesClass
{
    public partial class Form1 : Form
    {
        private Operacoes objOpera = new Operacoes();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            objOpera.valor1 = double.Parse(txtValor1.Text);
            objOpera.valor2 = double.Parse(txtValor2.Text);

            lblResultado.Text = objOpera.getSomar().ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResultado.Text = "";
            txtValor1.Focus();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            objOpera.valor1 = double.Parse(txtValor1.Text);
            objOpera.valor2 = double.Parse(txtValor2.Text);

            lblResultado.Text = objOpera.getSubtrair().ToString();
        }

        private void btnMultplicar_Click(object sender, EventArgs e)
        {
            objOpera.valor1 = double.Parse(txtValor1.Text);
            objOpera.valor2 = double.Parse(txtValor2.Text);

            lblResultado.Text = objOpera.getMultiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            objOpera.valor1 = double.Parse(txtValor1.Text);
            objOpera.valor2 = double.Parse(txtValor2.Text);

            lblResultado.Text = objOpera.getDividir().ToString();
        }

        private void btnExpnencial_Click(object sender, EventArgs e)
        {
            objOpera.valor1 = double.Parse(txtValor1.Text);
            objOpera.valor2 = double.Parse(txtValor2.Text);

            lblResultado.Text = objOpera.getExponecial().ToString();
        }
    }
}
