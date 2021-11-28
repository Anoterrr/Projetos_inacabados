using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAProjetoSistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trmTempo_Tick(object sender, EventArgs e)
        {
            /*if(this.Opacity == 1)
            {
                trmTempo.Enabled = false;
                MessageBox.Show("fim da carga!");
            }
            else
            {
                this.Opacity += 0.1;
            }*/
            if(pgrbProgress.Value == 100)
            {
                trmTempo.Enabled = false;
                this.Hide();
                frmLogin objTela = new frmLogin();
                objTela.ShowDialog();
            }
            else
            {
                this.Opacity += 0.1;
                pgrbProgress.Value += 10;
            }
        }
    }
}
