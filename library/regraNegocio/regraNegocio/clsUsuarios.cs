using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoDados;

namespace regraNegocio
{
    public class clsUsuario
    {
        private BancoDados objBD = new BancoDados();
        private clsPessoas objUsuario = new clsPessoas();

        public int pesId { get; set; }
        public string usrnome { get; set; }
        public string usrsenha { get; set; }
        public string usrstatus { get; set; }

        private string strErro = "";

        public bool getValidarAcesso()
        {
            try
            {
                string strSQL = "select * from usuario where usrnome = '" + this.usrnome + "' and usrsenha = '" + this.usrsenha + "'";
                string[] vtStruture = new string[1];
                string[] vtColumns = new string[1];
                vtStruture[0] = "usrnome";
                vtStruture[1] = "usersenha";
                vtColumns[0] = "usrnome";
                vtColumns[1] = "usrsenha";

                if (objBD.getConsultarDados(strSQL, vtStruture, vtColumns))
                {
                    return true;
                } else {
                    this.strErro = "Usuário e/o senha invalida";
                    return false;
                }
            }
            catch (Exception Erro)
            {
                this.strErro = Erro.Message;
                return false;
            }
        }

        /*
        public bool deleteUser()
        {
            try
            {
                string strSQL = ""
            }
            catch (Exception error)
            {

            }
        }
        */
        public string getErro()
        {
            return this.strErro;
        }
    }
}
