using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "BMW";
            carro1.Fabricante = "3251";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            Carro carro2 = new Carro("KA", "5463", 2018);

            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            Carro carro3 = new Carro()
            {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Ano = 2016
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");

        }
    }

        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

        public Carro() { }
            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
        }
    }
