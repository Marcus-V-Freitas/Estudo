using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"{Nome} {Idade}");
        }

        public void ApresentarConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
