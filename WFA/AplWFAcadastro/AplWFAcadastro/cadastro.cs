using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using regraNegocio;

namespace AplWFAcadastro
{
    public partial class cadastro : Form
    {
        string strErro;
        private clsPessoas objPerson = new clsPessoas();
        private clsUsuario objUser = new clsUsuario();

        public cadastro()
        {
            InitializeComponent();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            new login().ShowDialog();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //atribuir variáveis e chamar method e depois apresentar mensagem
            try
            {
                string id;
                string select;
                objPerson.pesNome = txtNome.Text.Trim();
                objPerson.pesCpf = txtNome.Text.Trim();
                objPerson.pesDtnascimento = txtNome.Text.Trim();
                if (objPerson.savePerson())
                {
                    objPerson.getConsultarPessoaCpf();
                   
                }
            }
            catch (Exception error)
            {
                this.strErro = error.Message;
            }
            //try
            //{
            //    string id = "";
            //    if (objDados != null)
            //    {
            //        if (!objDados.IsClosed) { objDados.Close(); }
            //    }

            //    // Cadastra a pessoa na table
            //    string strSQL = "insert into pessoas (pesid, pesnome, pescpf, pesdtnascimento) values (NULL, ";
            //    strSQL += "'" + txtNome.Text + "',";
            //    strSQL += "'" + txtCpf.Text + "',";
            //    strSQL += "'" + txtDtNascimento.Text + "')";
            //    objCmd.Connection = objCnx;
            //    objCmd.CommandText = strSQL;
            //    objCmd.ExecuteNonQuery();

            //    // Busca o código da pessoa cadastrada
            //    strSQL = "select * from pessoas where pesnome ='" + txtNome.Text + "' and pescpf = '" + txtCpf.Text + "'";
            //    objCmd.Connection = objCnx;
            //    objCmd.CommandText = strSQL;
            //    objDados = objCmd.ExecuteReader();

            //    if (objDados.HasRows)
            //    {
            //        objDados.Read();
            //        id = objDados["pesid"].ToString();
            //    } 
            //    if (objDados != null)
            //    {
            //        if (!objDados.IsClosed) { objDados.Close(); }
            //    }

            //    // Inserir os dados na tabela usuario
            //    strSQL = "insert into usuario (pesid, usrnome, usrsenha, usrstatus) values (";
            //    strSQL += id + ",";
            //    strSQL += "'" + txtNomeUser.Text + "',";
            //    strSQL += "'" + txtSenha.Text + "',";
            //    strSQL += "1)";
            //    objCmd.Connection = objCnx;
            //    objCmd.CommandText = strSQL;
            //    objDados = objCmd.ExecuteReader();

            //    MessageBox.Show("Cadastro feito com sucesso", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message, "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtDtNascimento.Text = "";
            txtNomeUser.Text = "";
            txtSenha.Text = "";
        }
    }
}
