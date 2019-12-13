using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ValorVsReferencia
    {
        public /*struct*/  class Depedente
        {
            public string nome;
            public int idade;
        }

        public static void Executar()
        {
            int numero = 3;
            int copiaDoNumero = numero;
            Console.WriteLine($"N: {numero} C: {copiaDoNumero}");
            numero++;
            Console.WriteLine($"N: {numero} C: {copiaDoNumero}");

            Depedente dep1 = new Depedente()
            {
                nome="Beto",
                idade=20
        };
            Depedente copiaDep1 = dep1;

            Console.WriteLine($" D: {dep1.nome} C: {dep1.idade}");
            Console.WriteLine($" D: {copiaDep1.nome} C: {copiaDep1.idade}");

            copiaDep1.idade= 21;
            dep1.nome = "Renato";

            Console.WriteLine($" D: {dep1.nome} C: {dep1.idade}");
            Console.WriteLine($" D: {copiaDep1.nome} C: {copiaDep1.idade}");


        }
    }
}
