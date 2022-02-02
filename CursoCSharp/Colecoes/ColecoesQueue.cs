using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            // Enfileirar
            fila.Enqueue("Marcos");
            fila.Enqueue("Marcelo");
            fila.Enqueue("Mariano");

            Console.WriteLine(fila.Peek()); // Pegar o elemento da lista sem remover
            Console.WriteLine(fila.Count); 

            Console.WriteLine(fila.Dequeue()); // Desenfileirar
            Console.WriteLine(fila.Count);

            // Passar por cada dado da fila
            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            // Fila heterogênea
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
