using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar as variáveis do ambiente
            double valor, antecessor;

            //Exibir mensagem para o usuário
            Console.Write("Digite um valor: ");

            //Ler os dados que o usuário digitou (Via teclado)
            valor = double.Parse(Console.ReadLine());

            //Calcular a fórmula do antecessor
            antecessor = valor - 1;

            //Apresenta o antecessor
            Console.WriteLine("Antecessor = " + antecessor.ToString());

            //Pausa a aplicação
            Console.ReadKey();
        }
    }
}
