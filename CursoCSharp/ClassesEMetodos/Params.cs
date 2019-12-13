using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var p in pessoas)
            {
                Console.WriteLine("Olá {0}", p);
            }
        }



        public static void Executar()
        {
            Recepcionar("Ana", "Pedro", "Manu", "Roger", "Bia");
        }
    }
}
