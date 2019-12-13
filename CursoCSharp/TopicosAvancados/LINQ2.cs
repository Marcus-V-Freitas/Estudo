using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
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

            var pedro = alunos.Single(aluno => aluno.nome.Equals("Pedro"));
            Console.WriteLine(pedro.nome);

            var fulano = alunos.SingleOrDefault(aluno => aluno.nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Fulano nao existe no contexto atual");
            }

            var ana = alunos.First(aluno => aluno.nome.Equals("Ana"));
            Console.WriteLine(ana.nome);


            var Sicrano = alunos.FirstOrDefault(aluno => aluno.nome.Equals("Sicrano"));
            if (Sicrano == null)
            {
                Console.WriteLine("Sujeito Inexistente");
            }

            var outraAna = alunos.Last(aluno => aluno.nome.Equals("Ana"));
            Console.WriteLine(outraAna.nome);

            var exemploSkip = alunos.Skip(1).Take(3);

            foreach(var skip in exemploSkip)
            {
                Console.WriteLine(skip.nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.nota);
            Console.WriteLine(menorNota);

            var somarTodas = alunos.Sum(aluno => aluno.nota);
            Console.WriteLine(somarTodas);

            var mediaTurma = alunos.Average(aluno => aluno.nota);
            Console.WriteLine(mediaTurma);

            //Media dos alunos aprovados

            var mediaAprovados = alunos.Where(a => a.nota >= 7).Average(aluno => aluno.nota);
            Console.WriteLine(mediaAprovados);
        }
    }
}
