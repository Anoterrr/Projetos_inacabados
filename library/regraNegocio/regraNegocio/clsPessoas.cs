using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoDados;
using System.Data;

namespace regraNegocio
{
    public class clsPessoas
    {
        //Métodos
        //    GravarPessoa() 
        //    ConsultarPessoa()
        //    ConsultarPessoa(id)
        //    ConsultarPessoa(cpf)
        //    ConsultarPessoa(nome)
        //    AlterarPessoa()
        //    DeletePessoa()

        private BancoDados objDb = new BancoDados();
        private clsUsuario objUsuario = new clsUsuario();

        public int pesId { get; set; }
        public string pesNome { get; set; }
        public string pesCpf { get; set; }
        public string pesDtnascimento { get; set; }

        private string strErro = "";

        public DataTable getConsultarUserPessoa()
        {
            try
            {
                string strSQL = "Select * From usuario inner join pessoas";
                DataTable dtRtn = null;
                string[] vtStruture = { "pesid", "pesnome", "clicpf", "clidtnascimento", "usrnome", "usrsenha", "usrstatus" };
                string[] vtColumns = { "pesid", "pesnome", "clicpf", "clidtnascimento", "usrnome", "usrsenha", "usrstatus" };
              
                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRtn = objDb.getDados();
                }
                return dtRtn;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPerson()
        {
            try
            {
                string strSQL = "select * from pessoas";
                DataTable dtRetorno = null;
                string[] vtStruture = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };
                string[] vtColumns = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };

                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRetorno = objDb.getDados();
                }
                return dtRetorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoaId()
        {
            try
            {
                string strSQL = "select * from pessoas where pesid = " + pesId;
                DataTable dtRetorno = null;
                string[] vtStruture = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };
                string[] vtColumns = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };

                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRetorno = objDb.getDados();
                }
                return dtRetorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoaNome()
        {
            try
            {
                string strSQL = "select * from pessoas where pesnome = " + pesNome;
                DataTable dtRetorno = null;
                string[] vtStruture = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };
                string[] vtColumns = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };

                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRetorno = objDb.getDados();
                }
                return dtRetorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoaCpf()
        {
            try
            {
                string id;
                string strSQL = "select * from pessoas where pescpf = " + pesCpf;
                DataTable dtRetorno = null;
                string[] vtStruture = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };
                string[] vtColumns = { "pesid", "pesnome", "pescpf", "pesdtnascimento", "usrnome" };

                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRetorno = objDb.getDados();
                    pesId= dtRetorno;
                }
                return dtRetorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoaUsuarios()
        {
            try
            {
                string strSQL = "select * from pessoas inner join usuario order by pesnome";
                DataTable dtRetorno = null;
                string[] vtStruture = { "pesid", "pesnome", "clicpf", "clidtnascimento", "usrnome" };
                string[] vtColumns = { "pesid", "pesnome", "clicpf", "clidtnascimento", "usrnome" };

                if (objDb.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    dtRetorno = objDb.getDados();
                }
                return dtRetorno;
            }
            catch (Exception error)
            {
                this.strErro = error.Message;
                return null;
            }
        }

        public bool savePerson()
        {
            bool rtn = false;
            try
            {
                string strSQL = "insert into pessoas (pesid, pesnome, pescpf, pesdtnascimento) values " +
                    "(NULL, " + pesNome + ", " + pesCpf + ", " + pesDtnascimento + ")";
                objDb.getExecutarSQL(strSQL);
                rtn = true;

                // Passar string para SQL para classe de banco;
                
            }
            catch (Exception error)
            {
                this.strErro = error.Message;
            }
            return rtn;
        }

        public bool alterPerson()
        {
            bool rtn = false;
            try
            {
                string strSQL = "Update pessoas set " +
                        "pesnome = '" + pesNome + "'," +
                        "pescpf = '" + pesCpf + "'," +
                        "pesdtnascimento = '" + pesDtnascimento + "' " +
                        "Where pescpf = " + pesCpf;
                objDb.getExecutarSQL(strSQL);
                rtn = true;
            } 
            catch (Exception error)
            {
                this.strErro = error.Message;
            }
            return rtn;

        }

        private bool deletePerson()
        {
            bool rtn = false;
            try
            {
                string strSQL = "Select * from pessoas Where pescpf = " + pesCpf;
                objDb.getExecutarSQL(strSQL);
                rtn = true;
            }
            catch (Exception error)
            {
                this.strErro = error.Message;
            }
            return rtn;
        }

        //public string getErrosr
    }
}
