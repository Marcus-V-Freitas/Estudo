﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Nao fez mais que a obrigação");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Que Feio!!!");
            }
        }
    }
}
