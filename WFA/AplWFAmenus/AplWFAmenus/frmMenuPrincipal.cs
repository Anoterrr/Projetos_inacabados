using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAmenus
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = @"C:\Users\gusta\AppData\Local\Programs\Microsoft VS Code\Code.exe";
            prcExecutor.Start();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = @"C:\Users\gusta\AppData\Local\Programs\Microsoft VS Code\Code.exe";
            prcExecutor.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "cal.exe";
            prcExecutor.Start();
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTela1 objTela = new frmTela1();
            objTela.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            wordToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            excelToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            calculadoraToolStripMenuItem_Click(sender, e);
        }

        private void tSSLdate_Click(object sender, EventArgs e)
        {
        }
    }
}
