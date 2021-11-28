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
    public partial class login : Form
    {
        private clsPessoas objPerson = new clsPessoas();

        public login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNomeUsr.Text = "";
            txtSenhaUsr.Text = "";
            txtNomeUsr.Focus();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new cadastro().ShowDialog();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se o DataReader está aberto
                if (objDados != null)
                {
                    if(!objDados.IsClosed) { objDados.Close(); }
                }
                string strSQl = "Select * from usuario where usrnome = '" + txtNomeUsr.Text.Trim() + "' and usrsenha ='" + txtSenhaUsr.Text + "'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSQl;
                objDados = objCmd.ExecuteReader();

                //Validar se dados foram encontrados
                if (objDados.HasRows)
                {
                    //Ocultar o formulário de Login
                    this.Hide();
                    //Carregar o formulário de Menu
                    new menus().ShowDialog();
                    //Fechar o banco de dados
                    objCnx.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha estão incorretos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeUsr.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
