using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();
            int numSecreto = random.Next(1, 16);
            bool numEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numSecreto == palpite)
                {
                    numEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    var textoAnterior = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O número foi encotrado em {tentativas}");
                    Console.BackgroundColor = corAnterior;
                    Console.ForegroundColor = textoAnterior;

                }
                else if (palpite > numSecreto)
                {
                    Console.WriteLine("Menor...Tente denovo");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }
                else
                {
                    Console.WriteLine("Maior...Tente denovo");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }
            }
        }
    }
}
