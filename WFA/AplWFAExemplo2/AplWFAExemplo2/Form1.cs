using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboListDropDownList.Items.Add(txtText.Text);
            txtText.Clear();
            txtText.Focus();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if(cboListDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado!", "ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboListDropDownList.Items.RemoveAt(cboListDropDownList.SelectedIndex);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            cboListDropDownList.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtText.Clear();
            cboListDropDownList.SelectedIndex = -1;
            lblPosicao.Text = "";
            lblSelected.Text = "";
            txtText.Focus();
        }

        private void cboListDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboListDropDownList.SelectedIndex != -1)
            {
                lblPosicao.Text = cboListDropDownList.SelectedIndex.ToString();
                lblSelected.Text = cboListDropDownList.SelectedItem.ToString();
                lblTotalItens.Text = cboListDropDownList.Items.Count.ToString();
            }
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e KeyChar ==13)
            {
                btnAdd_click(sender, e);
            }
        }
    }
}
