using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("f1"));
            Console.WriteLine(valor.ToString("c"));
            Console.WriteLine(valor.ToString("p"));
            Console.WriteLine(valor.ToString("#.##"));
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("c0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("d10"));

        }
    }
}
