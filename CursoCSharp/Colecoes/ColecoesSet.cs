using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>(); //O set não é indexado (Não é possível acessar ou saber os valores por indice, nem remove-los)
            //e também não aceita duplicação de mesmo item

            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("Temporada", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10),
                livro
            };


            carrinho.UnionWith(combo);  //Age como o AddRange -(Como o Set age como um conjunto o unionwith, fara a união dos itens da 1º
            //instância (carrinho) + os da outra instância (combo)  

            Console.WriteLine(carrinho.Count);
           //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
              //  Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));


        }
    }
}
