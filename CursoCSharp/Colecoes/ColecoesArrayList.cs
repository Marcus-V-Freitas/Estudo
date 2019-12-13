using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            foreach(Object item in arraylist)
            {
                Console.WriteLine($"{item} = {item.GetType()}");
            }
        }
    }
}
