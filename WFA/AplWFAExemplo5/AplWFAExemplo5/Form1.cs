using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExemplo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dtpCalendario_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpCalendario.Value.ToString("dd/MM/yyyy"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tmrTempo.Enabled)
            {
                tmrTempo.Enabled = false;
            }
            else
            {
                tmrTempo.Enabled = true;
            }
        }
    }
}
