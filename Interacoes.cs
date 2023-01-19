using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class Interacoes
    {
        public static void Ganha()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VOCÊ GANHOU");
            Console.ResetColor();
            Pontuacao.Ganhou();
        }
        public static void Perde()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VOCÊ PERDEU");
            Console.ResetColor();
            Pontuacao.Perdeu();
        }
        public static void Empate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("EMPATE");
            Console.ResetColor();
            Pontuacao.Empate();
        }
    }
}
