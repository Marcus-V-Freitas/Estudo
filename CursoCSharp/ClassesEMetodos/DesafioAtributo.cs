using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 9;
        public static void Executar()
        {
            //Acessar a variável 'a' dentro do Método Executar

            DesafioAtributo desafio = new DesafioAtributo();
                int resultado = desafio.a;
            Console.WriteLine($"A variável é de valor {resultado}.");

        }
    }
}
