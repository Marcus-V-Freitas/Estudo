using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar() 
        {
            var pilha = new Stack();  //LIFO último a chegar primeiro a sair conceito de pilha
            pilha.Push(3); // .push serve para adicionar mais um elemento a pilha 
            pilha.Push("A"); 
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n"+ pilha.Pop());  //.pop serve para tirar da pilha o último elemento

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine("\n" + pilha.Peek());
            Console.WriteLine(pilha.Count);
            var pilhas = new Stack<string>();
            pilhas.Push("jesus");

            Console.WriteLine(pilhas.Peek());

        }
    }
}
