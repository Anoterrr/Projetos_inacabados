using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using regraNegocio;

namespace AplWFAcadastro
{
    public partial class menus : Form
    {

        private clsPessoas objPerson = new clsPessoas();

        public menus()
        {
            InitializeComponent();
        }

        private void MenuSairSistema_Click(object sender, EventArgs e)
        {
            if (!objDados.IsClosed)
            {
                objDados.Close();
            }
            Application.Exit();
        }

        private void MenuCadastrar_Click(object sender, EventArgs e)
        {
            new cadastro().ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * From usuario inner join pessoas";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!!", "Consultar Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDados.Rows.Clear();
                    while (objDados.Read())
                    {
                        dgvDados.Rows.Add(
                            objDados["pesid"].ToString(),
                            objDados["usrnome"].ToString(),
                            objDados["usrsenha"].ToString(),
                            objDados["usrstatus"].ToString(),
                            objDados["pesnome"].ToString(), 
                            objDados["pescpf"].ToString(), 
                            objDados["pesdtnascimento"].ToString());
                    }
                }
                objDados.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "um erro ai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menus_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localHost;Database=bdcadastro;User=root;Pwd=Camaro_Verde_1!";
                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i <= 6; i++)
            {
                arrayList.Insert(i, dgvDados.Rows[e.RowIndex].Cells[i].Value);
            }
            txtId.Text = arrayList[0].ToString();
            txtNome.Text = arrayList[4].ToString();
            txtCpf.Text = arrayList[5].ToString();
            txtDtNascimento.Text = arrayList[6].ToString();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                
                objPerson.pesNome = txtNome.Text.Trim();
                objPerson.pesCpf = txtNome.Text.Trim();
                objPerson.pesDtnascimento = txtNome.Text.Trim();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "Update pessoas set " +
                        "pesnome = '" + txtNome.Text + "'," +
                        "pescpf = '" + txtCpf.Text + "'," +
                        "pesdtnascimento = '" + txtDtNascimento.Text + "' " +
                        "Where pesid = " + txtId.Text;

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!!!", "Sei lá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from pessoas Where pesid = " + txtId.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (objDados.HasRows)
                    {
                        objDados.Read();
                        string idVec = objDados["pesid"].ToString();
                    }
                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    if (MessageBox.Show("Deseja excluir", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        strSql = "Delete from pessoas Where pesid = " + idVec;
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Registro eliminado com sucesso!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}