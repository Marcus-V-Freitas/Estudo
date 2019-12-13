using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }
        public double PrecoDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
            //get{
            //return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            //this.nome = nome;
            Preco = preco;
        }

    }


    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Diração Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op2.Nome);

        }
    }
}
