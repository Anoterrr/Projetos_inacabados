using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtText.Clear();
            listBox1.Items.Clear();
            lblPosicao.Text = "";
            lblTextSelcted.Text = "";
            lblTotal.Text = "";
            txtText.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtText.Text);
            txtText.Clear();
            txtText.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            int posAnterior;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhuma opção foi selecionada!!!", "ListBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                posAnterior = listBox1.SelectedIndex - 1;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = posAnterior;
            }
        }
    }
}
