using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public class Animal
    {
        private string n;
        public string Nome { get =>n; set=>n=value; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        private double altura;
        public double Altura { get=>altura; set=>altura=value; }

        public Cachorro(string nome): base(nome)
        {
            Console.WriteLine($"Cachorro {nome} foi inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"O cachorro {Nome} tem {Altura}cm de altura";
        }

    }


    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");       //Construtor que chama um construtor na própria classe (this)
            var max = new Cachorro("Max", 40.0);    //Construtor que chama um construtor base de outra classe (base)
                                                    //Construtores seguem uma hierarquia
            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
