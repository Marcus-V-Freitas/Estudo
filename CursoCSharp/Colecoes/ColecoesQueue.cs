using System;
using System.Collections;  //necessário para fila heterogenia
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue //Padrão Fifo - Primeiro a chegar primeiro a sair (fila), ela aceita valores repetidos
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");    //Enqueue serve para enfilerar os tipos do 1 ao ultimo
            fila.Enqueue("Sincrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());  //.Peek serve para representar o primeiro elemento a ser retirado da lista

            Console.WriteLine(fila.Count); //Representar que o console nao retira dados da lista

            Console.WriteLine(fila.Dequeue()); //.Dequeue serve para tirar o primeiro elemento da lista

            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Peek());

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); //Essa declaração permite colocar tipos heterogenios (necessita do
            //Using System.Collections;

            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); //.Contains verifica se o item está dentro da fila ou não (maiuscula e minuscula diferencua)
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}
