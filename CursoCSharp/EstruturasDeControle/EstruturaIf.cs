using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            //Console.WriteLine("Possui um bom comportamento? (S/N)");
            //entrada = Console.ReadLine();
            Console.WriteLine("Possui bom comportamento? ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
                bomComportamento = true;

            bomComportamento = entrada.ToLower() == "s";



            if(nota>=9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra.");
            }

             
        }
    }
}
