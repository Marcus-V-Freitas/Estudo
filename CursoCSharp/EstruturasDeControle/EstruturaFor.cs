using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //for(int i=0; i<=10; i++)                               Exemplo Básico de For
            //{
            //    Console.WriteLine($"O valor do i é {i}");
            //}

            double somatorio = 0;

            Console.WriteLine("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for(int i=1; i<=tamanhoTurma; i++)                        //Enquanto
            {
                Console.WriteLine("Informe a nota do aluno {0}", i);
                string entrada =Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;

            Console.WriteLine($"Média da turma é: {media}");
        }
    }
}
