using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class RodadaAuto
    {
        public static void Run()
        {
            Console.WriteLine("Você deseja jogar quantas vezes automaticamente?");
            int qntdRodadas = Convert.ToInt32(Console.ReadLine());

            while(qntdRodadas == null || qntdRodadas <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um valor inteiro válido!");
                Console.ResetColor();
                Console.WriteLine("Você deseja jogar quantas vezes automaticamente?");
                qntdRodadas = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= qntdRodadas; i++)
            {
                Random random = new Random();
                Dictionary<int, string> escolhas = new Dictionary<int, string>
                {
                { 1, "pedra" },
                { 2, "papel" },
                { 3, "tesoura" }
                };

                int escolhaint = random.Next(1, 4);
                string escolha = escolhas[escolhaint];
                int adversarioint = random.Next(1, 4);
                string adversario = escolhas[adversarioint];

                Console.WriteLine();
                Console.WriteLine($"Você escolheu {escolha.ToUpper()} e o adversário escolheu {adversario.ToUpper()}.");
                Verificacoes.Verifica(escolha, adversario);
                Console.WriteLine();
            }
        }
    }
}
