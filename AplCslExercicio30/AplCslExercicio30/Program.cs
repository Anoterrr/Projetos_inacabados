using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, cont = 0;
            Console.Write("Digite o 1° valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 1° valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if(valor1 > valor2)
            {
                Cosole.WriteLine("O segundo número é maior que o primeiro valor");
            }
            else
            {
                for (int i = valor1; i <= valor2; i++)
                {
                    cont += i;
                }
                Console.Write("A soma dos numeros é: " + cont.ToString();
            }
            Console.ReadKey();
        }
    }
}
