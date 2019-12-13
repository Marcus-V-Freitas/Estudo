using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número escolhido foi: {numero}");

            for (int i=1; i<=50; i++)
            {

                if (numero == i)
                {
                    Console.WriteLine($"Número {i} é o escolhido?: Sim");
                    break;
                }
                else
                {
                    Console.WriteLine($"Número {i} é o escolhido?: Não");
                }
            }
        }
    }
}
