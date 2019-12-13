using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {

        public static void AlterarRef(ref int id)
        {
            id += 1000;
        }

        public static void AlterarOut(out int id1, out int id2)
        {
            id1 = 1;
            id2 = 2;
            id1 += 15;
            id2 += 17;
        }


        public static void Executar()
        {
            int a = 1;
            AlterarRef(ref a);
            Console.WriteLine(a);
            int b = 5;
            AlterarOut(out b, out int c);
            Console.WriteLine(b);
                Console.WriteLine(c);
        }
    }
}
