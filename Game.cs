using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class Game
    {

        public static void Run()
        {
            Console.WriteLine("Bem vindo ao Jokenpô");
            Console.WriteLine("Você deseja jogar Manualmente ou Automáticamente? (m/a)");
            string escolha = Console.ReadLine().ToLower();


            if (escolha == "a")
            {
                while (true)
                {
                    RodadaAuto.Run();

                    JogarNovamente.Run();
                }
            }
            else if (escolha == "m")
            {
                while (true)
                {
                    RodadaManual.Run();

                    JogarNovamente.Run();
                }
            }
            else
            {
                while (escolha != "m" && escolha != "a")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Responda Corretamente!");
                    Console.ResetColor();
                    Console.WriteLine("Você deseja jogar Manualmente ou Automáticamente? (m/a)");
                    escolha = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
