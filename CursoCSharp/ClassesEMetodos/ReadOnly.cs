using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {

        public class Cliente
        {
            string nome;
            public readonly DateTime nascimento;


            public Cliente(string nome, DateTime nascimento)
            {
                this.nome = nome;
                this.nascimento = nascimento;
            }

            public string Getnascimento() {

                return string.Format($"{nascimento.Day}/{nascimento.Month}/{nascimento.Year} ");
            }
        }

        public static void Executar()
        {
            var cliente1 = new Cliente("Ana Silva", new DateTime(2010, 10, 15));
            Console.WriteLine(cliente1.Getnascimento());

            //cliente1.nascimento = new DateTime(2013, 06, 05);   //Por ser um campo de leitura ele não vai alterar mais

            var cliente2 = new Cliente("João", new DateTime(2014, 06, 07));
        }
    }
}
