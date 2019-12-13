using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa p = new Pessoa();
                
                 p.Nome = "João";
                p.Idade = 31;

            //  Console.WriteLine($"{p.Nome} tem {p.Idade} anos");

            p.ApresentarConsole(); //Inflexível só retorna o método


            var fulano = new Pessoa();

            fulano.Nome = "Luiz";
            fulano.Idade = 15;

            var Apresentacao = fulano.Apresentar(); //flexível pois retorna no objeto (mais opções)
            Console.WriteLine(Apresentacao);
            fulano.zerar();
            Console.WriteLine(fulano.Apresentar());
        }
        }
    }
