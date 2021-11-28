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
    public partial class ConsultList : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        public ConsultList()
        {
            InitializeComponent();
        }

        private void ConsultList_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=Localhost;Database=bdCapacitacao;User=root;Pwd=Camaro_Verde_1!";
                objCnx.Open();
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
                string strSql;
                strSql = "Select * from tblagenda Order By agdnome";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!!", "COnsulta LIsta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (objDados.Read())
                    {
                        dgvData.Rows.Add(null, objDados["agdid"].ToString(), objDados["agdnome"].ToString(), objDados["agdemail"].ToString(), objDados["agdtelefone"].ToString(), objDados["agdcpf"].ToString());
                    }
                }
                objDados.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            this.Close();
        }
    }
}
