using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFA1
{
    public partial class frmAntecessor : Form
    {
        public frmAntecessor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbEntrada.Text = "";
            lblResultadoCalculo.Text = "";

            txtbEntrada.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double antecessor = 0;
            //Calcular o antecessor
            antecessor = double.Parse(txtbEntrada.Text) - 1;
            
            //Exibir o resultado do cáculo na label lblResultado
            lblResultadoCalculo.Text = antecessor.ToString();
        }
    }
}
