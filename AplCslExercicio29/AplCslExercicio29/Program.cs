using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, cont = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Digite o " + i.ToString() + "° número:");
                number = int.Parse(Console.ReadLine());
                if(number < 40)
                {
                    cont += number;
                }
            }
            Console.WriteLine("O valor dos números menores que 40 somados é: " + cont.ToString());
            Console.ReadKey();
        }
    }
}
