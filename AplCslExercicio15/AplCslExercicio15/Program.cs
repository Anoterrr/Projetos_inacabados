using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, duration;

            Console.Write("Digite a hora de inicio da partida: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora de termino da partida: ");
            end = int.Parse(Console.ReadLine());

            if(start < end)
            {
                duration = end - start;
            }
            else{
                duration = end + (24 - start);
            }
            Console.WriteLine("A duração do jogo foi de: " + duration.ToString());
            
            Console.ReadKey();
        }
    }
}
