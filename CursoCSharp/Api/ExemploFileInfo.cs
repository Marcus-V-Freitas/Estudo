using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                
                    if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
                }
        }
        public static void Executar()
        {
            var CaminhoOrigem = @"~/arq_Origem.txt".ParseHome();
            var CaminhoDestino = @"~/arq_Destino.txt".ParseHome();
            var CaminhoCopia= @"~/arq_Copia.txt".ParseHome();
            ExcluirSeExistir(CaminhoOrigem, CaminhoDestino, CaminhoCopia);

            using(StreamWriter sw=new StreamWriter(CaminhoOrigem))
            {
                sw.Write("Arquivo Original");
            }

            FileInfo origem = new FileInfo(CaminhoOrigem);

            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(CaminhoCopia);
            origem.MoveTo(CaminhoDestino);
        }
    }
}
