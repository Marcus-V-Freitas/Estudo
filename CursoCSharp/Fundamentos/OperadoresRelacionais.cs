using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;

            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            double notaCorte = 7.0;

            //> (Maior que) e < (Menor que)
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota<0.0);

            //== (Igual a)

            Console.WriteLine("Perfeito? {0}", nota == 10.0);

            //!= (Diferente de)

            Console.WriteLine("Melhorar? {0}", nota != 10.0);

            //>= (Maior ou igual a) e <= (Menor ou igual a)

            Console.WriteLine("Média? {0}", nota >= notaCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaCorte);
            Console.WriteLine("Reprovado {0}", nota <=3.0);

        }
    }
}
