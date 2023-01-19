using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class JogarNovamente
    {
        public static void Run()
        {
            Console.WriteLine("Deseja jogar novamente? (s/n)");
            string resposta = Console.ReadLine();

            while (resposta != "s" && resposta != "n")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Responda corretamente!");
                Console.ResetColor();
                Console.WriteLine("Deseja jogar novamente? (s/n)");
                resposta = Console.ReadLine();
            }
   
            if (resposta == "n")
            {
                Pontuacao.Get();
                for (int i = 5; i >= 1; i--)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Fechando em {i} segundos");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
