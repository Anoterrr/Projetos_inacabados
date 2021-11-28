using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplWFABancoDados
{
    public partial class BancoDados : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        public BancoDados()
        {
            InitializeComponent();
        }

        private void BancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=bdCapacitacao;User=root;Pwd=Camaro_Verde_1!";
                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from tblagenda where agdid = " + txtCode.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows)
                {
                    MessageBox.Show("Código existente!!!", "ADD.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "insert into tblagenda (agdid, agdnome, agdemail, agdtelefone, agdcpf) values (";
                    strSql += txtCode.Text + ",";
                    strSql += "'" + txtName.Text + "',";
                    strSql += "'" + txtEmail.Text + "',";
                    strSql += "'" + txtPhone + "',";
                    strSql += "'" + txtCpf.Text + "')";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluido com sucesso!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from tblagenda Where agdid = " + txtCode.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código existente!!!", "ADD.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "Update tblagenda set ";
                    strSql += "agdnome = '" + txtName.Text + "',";
                    strSql += "agdemail = '" + txtEmail.Text + "',";
                    strSql += "agdtelefone = '" + txtPhone.Text + "',";
                    strSql += "agdcpf = '" + txtCpf.Text + "' ";
                    strSql += "Where agdid = " + txtCode.Text;

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string strSql = "Select * from tblagenda Where agdid = " + txtCode.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }

                    if(MessageBox.Show("Deseja excluir", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        strSql = "Select * from tblagenda Where agdid = " + txtCode.Text;
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

        private void btnConsult_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from tblagenda Where agdid = " + txtCode.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                if(!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                }
                else
                {
                    objDados.Read();
                    txtName.Text = objDados["agdnome"].ToString();
                    txtEmail.Text = objDados["agdemail"].ToString();
                    txtPhone.Text = objDados["agdtelefone"].ToString();
                    txtCpf.Text = objDados["agdcpf"].ToString();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCpf.Text = "";
            txtCode.Focus();
        }

        private void btnConsultDataList_Click(object sender, EventArgs e)
        {
            ConsultList objTela = new ConsultList();
            objTela.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            Application.Exit();
        }
    }
}
