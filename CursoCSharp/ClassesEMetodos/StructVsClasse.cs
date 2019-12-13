using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Sponto
    {
        public int X;
        public int Y;
    }
    public class Cponto
    {
        public int X;
        public int Y;
    }


    class StructVsClasse
    {
        public static void Executar()
        {
            Sponto ponto1 = new Sponto { X = 1, Y = 3 };
            Sponto CopiaPonto1 = ponto1;
            ponto1.X = 3;
            Console.WriteLine("Valor do ponto1: {0}", ponto1.X);
            Console.WriteLine("Valor da copia do ponto1: {0}", CopiaPonto1.X);

            Cponto ponto2 = new Cponto { X = 1, Y = 3 };
            Cponto CopiaPonto2 = ponto2;
            ponto2.X = 3;
            Console.WriteLine("Valor do ponto2: {0}", ponto2.X);
            Console.WriteLine("Valor do copia do ponto2: {0}", CopiaPonto2.X);
        }
    }
}
