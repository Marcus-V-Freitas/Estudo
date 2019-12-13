using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno");
            double.TryParse(Console.ReadLine(), out double nota);
            if(nota>=9.0 && nota <= 10.0)
            {
                Console.WriteLine("Quadro de Honra"); 
            } else if (nota >= 7.0)  //Não precisa-se usar o (&& < 9.0) pois isso já é esperado devido a outra condição
            {
                Console.WriteLine("Aprovado"); 
            } else if (nota >= 5)   //Não precisa-se usar o (&& < 7.0) pois isso já é esperado devido a outra condição
            {
                Console.WriteLine("Recuperação"); 
            }
            else
            {
                Console.WriteLine("Te vejo na próxima...");
            }
            Console.WriteLine("Fim");
        }
    }
}
