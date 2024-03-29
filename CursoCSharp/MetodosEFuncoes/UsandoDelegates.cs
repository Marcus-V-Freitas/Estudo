﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine(x+y);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(6,9));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7,8);


        }
    }
}
