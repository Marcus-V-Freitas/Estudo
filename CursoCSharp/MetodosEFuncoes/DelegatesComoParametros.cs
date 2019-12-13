using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado é:" + resultado;
        }

        

        public static void Executar()
        {
            Operacao Subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(Soma, 2, 3));
            Console.WriteLine(Calculadora(Subtracao,7,3));


        }
    }
}
