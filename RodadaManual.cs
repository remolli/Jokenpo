using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class RodadaManual
    {
        public static void Run()
        {
            Random random = new Random();
            Dictionary<int, string> escolhas = new Dictionary<int, string>
            {
                { 1, "pedra" },
                { 2, "papel" },
                { 3, "tesoura" }
            };

            Console.WriteLine("Escolha entre Pedra, Papel e Tesoura");

            string escolha = Console.ReadLine().ToLower();
            int adversarioint = random.Next(1, 4);
            string adversario = escolhas[adversarioint];

            while(escolha != "papel" && escolha != "pedra" && escolha != "tesoura")
            {
                Console.Clear();
                Console.WriteLine("Escreva Corretamente!");
                Console.WriteLine("Escolha entre Pedra, Papel e Tesoura");
                escolha = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Você escolheu {escolha.ToUpper()} e o adversário escolheu {adversario.ToUpper()}.");

            Verificacoes.Verifica(escolha, adversario);
        }
    }
}
