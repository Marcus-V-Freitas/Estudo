using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {

        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;


        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {
        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }



    }

    class AtributosEstaticos
    {
        
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.3);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 3.2
            };

            Console.WriteLine($"{produto1.CalcularDesconto()}");
            Produto.Desconto = 0.5;
            Console.WriteLine($"{produto2.CalcularDesconto()}");

        }
        }
    }
