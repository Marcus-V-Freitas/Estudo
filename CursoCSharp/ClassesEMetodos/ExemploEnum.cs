using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

        public class Filme
        {
            public string Título;
            public Genero GeneroFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmefamilia = new Filme();

            filmefamilia.Título = "Shark";
            filmefamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine("{0} é de {1}", filmefamilia.Título, filmefamilia.GeneroFilme);
        }
    }
}
