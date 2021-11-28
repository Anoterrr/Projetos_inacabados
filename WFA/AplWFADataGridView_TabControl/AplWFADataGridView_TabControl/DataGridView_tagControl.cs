using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFADataGridView_TabControl
{
    public partial class DataGridView_tagControl : Form
    {
        public DataGridView_tagControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(txtbCod.Text, txtbName.Text);
            txtbCod.Text = "";
            txtbName.Text = "";
            txtbCod.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbCod.Text = "";
            txtbName.Text = "";
            dgvData.Rows.Clear();
            txtbCod.Focus();

        }

        private void txtbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnAdd_Click(null, null);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Insert(1, txtbCod.Text, txtbName.Text);
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            dgvData.Rows.RemoveAt(dgvData.CurrentRow.Cells[0].RowIndex);
        }
    }
}
