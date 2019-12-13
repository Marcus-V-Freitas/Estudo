using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
               var p3 = p2;

            //Comparação por referência de endereço de memória
            Console.WriteLine(p1==p2);
            Console.WriteLine(p2==p3);

            Console.WriteLine(p1.Equals(p2)); //Sobreescrita do método Equals para que ele não compare em questão e endereço de memória
            //e sim em quwestão de dados armazenados do arquivo ColecoesList

        }
    }
}
