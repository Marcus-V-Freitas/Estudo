using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    public class Produto
    {
        public string nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.Preco = preco;
        }


        // Ambos podem ser gerados automaticamente pelo atalho ctrl+.

        //Método Gethashcode e Equals que sãp padrões, mas devem ser sobreescritos
        //Trabalham em cima do tipo hash (Ex: Set, onde a lista não tem 2 elementos iguais)
        //Equals: Verifica a igualdade dos objetos
        //GetHashCode: Usado para compor a igualdade do objeto junto com o Equals, formando indices (como banco de dados) 
        //para agrupar por conjuntos de dados para depois serem verificados pelo Equals
        //A maior vantagem em sobrescrever esses métodos é melhorar a busca dos objetos.

        public override bool Equals(object obj)
        {
            var produto = obj as Produto;
            return produto != null &&
                   nome == produto.nome;
        }

        public override int GetHashCode()
        {
            return nome.Length;
        }

        //public override bool Equals(object obj)
        //{
        //    Produto outroproduto = (Produto)obj;
        //    bool mesmonome = nome == outroproduto.nome;
        //    bool mesmopreco = Preco == outroproduto.Preco;
        //    return mesmonome && mesmopreco;
        //}



    }

    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("Temporada", 99.9),
                new Produto("Poster", 10)
            };


            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));


        }
    }
}
