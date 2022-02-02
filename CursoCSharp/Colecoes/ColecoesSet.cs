using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>(); //Lista Homogênea
            carrinho.Add(livro);

            // Adicionar  vários itens na lista

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada de GOT", 99.9),
                new Produto("Placa metálica", 20)
            };

            carrinho.UnionWith(combo); // Adiciona vários elementos de uma única vez
            Console.WriteLine(carrinho.Count); // Tamanho da lista
            //carrinho.RemoveAt(3); // Remover por índice

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item) + " "); // Estrutura Indexada
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
