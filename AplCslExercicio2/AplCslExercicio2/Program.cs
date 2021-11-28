using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base, altura, area;

            Console.WriteLine("Digite a base: ");
            Base = double.Parse (Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            area = Base * altura;
            Console.WriteLine("Área do retângulo: " + area.ToString());
            Console.ReadKey();
        }
    }
}
