using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp.txt".ParseHome();
            var novoDirDestino = @"~/PastaCharpDestino.txt".ParseHome();
            var DirProjeto = @"~/Source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }


            Directory.CreateDirectory(novoDir);

            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("Pastas");

            var pastas = Directory.GetDirectories(DirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("Arquivos");

            var arquivos = Directory.GetFiles(DirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Raiz");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);


        }
    }
}
