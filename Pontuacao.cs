using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class Pontuacao
    {
        static int ganhos { get; set; }
        static int perdas { get; set; }
        static int empates { get; set; }
        public static void Ganhou()
        {
            ganhos++;
        }
        public static void Perdeu()
        {
            perdas++;
        }
        public static void Empate()
        {
            empates++;
        }

        public static void Get()
        {
            Console.Clear();
            Console.WriteLine($"Ganhos: {ganhos} | Perdas: {perdas} | Empates {empates}");
        }
    }
}
