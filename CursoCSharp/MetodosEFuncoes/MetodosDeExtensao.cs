using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{

    public static class ExtensoesNumeros
    {
        public static int Soma(this int num, int outro)
        {
            return num + outro;
        }

        public static double Subtracao(this double num, int outro)
        {
            return num - outro;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 6;
            double num = 17;
            Console.WriteLine(numero.Soma(6));
            Console.WriteLine(num.Subtracao(8));

            Console.WriteLine(7.8.Subtracao(6));
        }
    }
}
