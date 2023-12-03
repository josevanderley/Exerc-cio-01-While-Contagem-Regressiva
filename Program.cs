using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01_While__Contagem_Regressiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Vamos começar o programa Contagem regressiva**********");

            Console.Write("Digite um número para iniciar a contagem regressiva: ");

            if (int.TryParse(Console.ReadLine(), out int numeroInicial))
            {
                while (numeroInicial >= 0)
                {
                    Console.WriteLine(numeroInicial);
                    numeroInicial--;
                }

                Console.WriteLine("Fim da contagem regressiva!");
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");

                Console.ReadKey();

            }
        }
    }
}
    