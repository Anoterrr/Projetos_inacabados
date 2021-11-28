using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdImage1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.Image = Properties.Resources.Forza_Horizon_4__3_;
        }

        private void rdImage2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.Image = Properties.Resources.Forza_Horizon_4__4_;
        }

        private void rdWthoutImage_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void rdWithoutBordas_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.None;
        }

        private void rdFixaS_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
        }

        private void rd3d_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imagemOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (imagemOnOff.Checked)
            {
                pcbFoto.Visible = true;
            }
            else
            {
                pcbFoto.Visible = false;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
