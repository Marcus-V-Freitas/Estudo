using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine($"{dia:D2} {mes:D2} {ano.ToString("####")}");
        }

        public static void Executar()
        {
            Formatar(mes: 6, dia: 1, ano: 2015);
        }
    }
}
