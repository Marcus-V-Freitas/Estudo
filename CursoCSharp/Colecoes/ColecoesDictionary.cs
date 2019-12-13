using System;
using System.Collections.Generic; //Depende do Generics
using System.Text;

namespace CursoCSharp.Colecoes
{
   internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();   //O Dictionary é uma estrutura chave e valor, onde a chave não repete (Parecido com o Set)
            //e onde o valor pode repetir (Parecido com a List)
            //Precisa ser declarados 2 tipos

            filmes.Add(2000, "O Gladiador"); //.Add adiciona valores no dictionary
            filmes.Add(2002,"Homem Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");


            if (filmes.ContainsKey(2004))  //.ContainsKey verifica se existe a chave passada
            {
                Console.WriteLine($"2004:{filmes[2004]}"); //[] serve para retorna o valor, sem segurança 
                Console.WriteLine($"2004: {filmes.GetValueOrDefault(2004)}"); //.GetValueOrDefault serve para retornar o valor de forma segurança


                Console.WriteLine(filmes.ContainsValue("Amnésia")); // .ContainsValue Retorna boolean confirmando presença do valor

                Console.WriteLine($"Removeu: {filmes.Remove(2004)}"); //.Remove remove do dictionary a partir da chave

                filmes.TryGetValue(2006, out string filme2006); //Tenta pegar o valor de uma variavel

                Console.WriteLine($"{filme2006}");

                foreach(var chave in filmes.Keys) //Varre pela chave
                {
                    Console.WriteLine(chave);
                }

                foreach (var valor in filmes.Values) //Varre pelos valores
                {
                    Console.WriteLine(valor);
                }

                foreach (KeyValuePair<int, string> filme in filmes) //Varre chave e valor da forma padrão
                {
                    Console.WriteLine(filme.Key + " " + filme.Value);
                }

                foreach (var filme in filmes) //Varre chave e valor da forma simplificada
                {
                    Console.WriteLine(filme.Key + " " + filme.Value);
                }

            }
        }
    }
}
