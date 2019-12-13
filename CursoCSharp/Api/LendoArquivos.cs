using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/Lendo_Arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter SW = File.AppendText(path))
                {
                    SW.WriteLine("Produto; Preco; Qtd");
                    SW.WriteLine("Caneta; 3.59; 89");
                    SW.WriteLine("Borracha;2.89;27");
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
                }catch (Exception ex) {
                Console.WriteLine(ex.Message);
                {

                }
            }
        }
    }
}
    

