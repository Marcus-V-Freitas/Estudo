using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executarTrabalho1 = true;
            var executarTrabalho2 = false;

            //Comprar TV
            Boolean comprarTV50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine($"Comprou a televisão de 50? {comprarTV50}");

            //Comprar Sorvete
            Boolean comprarSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine($"Comprou o sorvete? {comprarSorvete}");

            Boolean ComprarTV32 = executarTrabalho1 ^ executarTrabalho2;
            Console.WriteLine($"Comprou a televisão de 32? {ComprarTV32}");

            Console.WriteLine($"Foi uma escolha saudável com o sorvete? {!comprarSorvete}");
        }
    }
}
