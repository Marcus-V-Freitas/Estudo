using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno {
        public string nome;
        public int idade;
        public double nota;


    }

    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){nome="Pedro", idade=29, nota=8.0},
                new Aluno(){nome="Andre", idade=21,nota=4.3},
                new Aluno(){nome="Ana", idade=25,nota=9.5},
                new Aluno(){nome="Jorge", idade=20,nota=8.5},
                new Aluno(){nome="Ana", idade=20,nota=7.7},
                new Aluno(){nome="Julia", idade=22,nota=7.5},
                new Aluno(){nome="Marcio", idade=18,nota=6.8}
            };

            Console.WriteLine("Aprovados");
            var aprovados = alunos.Where(a => a.nota >= 7.0).OrderBy(a => a.nome);

            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.nome);
            }

            Console.WriteLine("Chamada");
            var chamada = alunos.OrderBy(a => a.nome).Select(a => a.nome);

            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("Aprovados por nota e ordenados por idade");
            var alunosAprovados =
                from aluno in alunos
                where aluno.nota >= 7.0
                orderby aluno.idade
                select aluno.nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
