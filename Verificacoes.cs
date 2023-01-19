using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class Verificacoes
    {
        public static void Verifica(string escolha, string adversario)
        {
            if (escolha == adversario)
            {
                Interacoes.Empate();
            }
            else
            {
                if (escolha == "pedra")
                {
                    if (adversario == "tesoura")
                    {
                        Interacoes.Ganha();
                        
                    }
                    else
                    {
                        Interacoes.Perde();
                    }
                }
                if (escolha == "papel")
                {
                    if (adversario == "pedra")
                    {
                        Interacoes.Ganha();
                    }
                    else
                    {
                        Interacoes.Perde();
                    }
                }
                if (escolha == "tesoura")
                {
                    if (adversario == "papel")
                    {
                        Interacoes.Ganha();
                    }
                    else
                    {
                        Interacoes.Perde();
                    }
                }
            }
        }
    }
}
