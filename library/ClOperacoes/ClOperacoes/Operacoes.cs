using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClOperacoes
{
    public class Operacoes
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public Operacoes()
        {
            this.valor1 = 0;
            this.valor2 = 0;
        }

        public double getSomar()
        {
            return this.valor1 + this.valor2;
        }
        public double getSubtrair()
        {
            return this.valor1 - this.valor2;
        }
        public double getMultiplicar()
        {
            return this.valor1 * this.valor2;
        }
        public double getDividir()
        {
            return this.valor1 / this.valor2;
        }
        public double getExponecial()
        {
            return Math.Pow(this.valor1, this.valor2);
        }
    }
}
