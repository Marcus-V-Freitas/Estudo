﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1=3;

            //Aritméticos: + - * /

            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; //num1 = num1 - 3;
            num1 *= 5; //num1 = num1 * 5;
            num1 /= 2; //num1 = num1 / 2;

            Console.WriteLine(num1);

            //Incremento e Decremento

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} e {b}");

            //Ponteiro para posição de memória (Dynamic)

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;

            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
