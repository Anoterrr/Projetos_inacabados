using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace bancoDados
{
    public class BancoDados
    {
        // Definition of atributs from the class
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        private string strErro = "";
        private DataTable dtDados = new DataTable();

        private bool getConectar()
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=bdcadastro;user=root;pwd=Camaro_Verde_1!";
                objCnx.Open();
                return true;
            }
            catch(Exception Erro)
            {
                this.strErro = Erro.Message;
                return false;
            }
        }
        private bool getDesconectar()
        {
            try
            {
                if(objCnx.State == ConnectionState.Open)
                {
                    objCnx.Close();
                }
                return true;
            }
            catch(Exception Erro)
            {
                this.strErro = Erro.Message;
                return false;
            }
        }
        public int getExecutarSQL(string strSQL)
        {
            try
            {
                int ingRetorno = 0;
                if (getConectar())
                {
                    if(objDados != null)
                    {
                        if(!objDados.IsClosed) { objDados.Close(); }
                    }
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    ingRetorno = objCmd.ExecuteNonQuery();
                }
                return ingRetorno;
            }
            catch (Exception Erro)
            {
                this.strErro = Erro.Message;
                return 0;
            }
            finally
            {
                getDesconectar();
            }
        }
        public bool getConsultarDados(string strSQL, string[] vtEstruturaTabela, string[] vtDadosTabela)
        {
            try
            {
                bool blnretorno = false;
                dtDados.Columns.Clear();
                if(getConectar())
                {
                    // Create a virtual table estrutured defined by the user
                    for(int IngColuna = 0; IngColuna < vtEstruturaTabela.Length; IngColuna++)
                    {
                        dtDados.Columns.Add(vtEstruturaTabela[IngColuna].ToString());
                    }

                    if(objDados != null)
                    {
                        if(!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while(objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            for (int IngColuna = 0; IngColuna < vtDadosTabela.Length; IngColuna++)
                            {
                                drRegistro[vtEstruturaTabela[IngColuna].ToString()] = objDados[vtDadosTabela[IngColuna].ToString()].ToString();
                            }
                            dtDados.Rows.Add(drRegistro);
                        }
                    }
                    if(objDados != null)
                    {
                        if(!objDados.IsClosed) { objDados.Close(); }
                    }
                    blnretorno = true;
                }
                return blnretorno;
            }
            catch (Exception Erro)
            {
                this.strErro = Erro.Message;
                return false;
            }
            finally
            {
                getDesconectar();
            }
        }

        public DataTable getDados()
        {
            return dtDados;
        }

        public string getErro()
        {
            return strErro;
        }
    }
}
