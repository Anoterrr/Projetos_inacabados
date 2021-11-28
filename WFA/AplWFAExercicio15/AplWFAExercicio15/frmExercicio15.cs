using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExercicio15
{
    public partial class frmExercicio15 : Form
    {
        public frmExercicio15()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbFinal.Text = "";
            txtbInicial.Text = "";
            lblResultado.Text = "";
            txtbInicial.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int start = 0, end = 0, duration = 0;
            start = int.Parse(txtbInicial.Text);
            end = int.Parse(txtbFinal.Text);
            if(start < end)
            {
                duration = end - start;
            }
            else
            {
                duration = end + (24 - start);
            }
            lblResultado.Text = duration.ToString();
        }
    }
}
