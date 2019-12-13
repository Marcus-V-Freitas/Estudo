using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valornegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            // Negação Aritmética

            Console.WriteLine(-valornegativo);

            //Negação Booleana

            Console.WriteLine(!booleano);

            //Incremento (trás)

            numero1++;
            Console.WriteLine(numero1);

            //Decremento (frente)

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1}, { numero2}");

        }
    }
}
