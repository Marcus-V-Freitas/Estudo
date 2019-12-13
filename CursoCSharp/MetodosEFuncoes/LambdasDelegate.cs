using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(5,2));
            Console.WriteLine(multi(12,8));
        }
    }
}
