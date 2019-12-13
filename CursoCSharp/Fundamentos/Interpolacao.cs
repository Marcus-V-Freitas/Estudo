using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double valor = 5800.00;

            Console.WriteLine("O " + nome + " da " +marca+ " custa " +valor);

            Console.WriteLine("O {0} da {1} custa {2}", nome, marca, valor);

            Console.WriteLine($"O {nome} da {marca} custa {valor}");
            Console.WriteLine($"1+1={1+1}!");
        }
    }
}
