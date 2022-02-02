using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Miranha");
            filmes.Add(2020, "Vingadores");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2000))
            {
                Console.WriteLine("2000: " + filmes[2000]);
                Console.WriteLine("2000: " + filmes.GetValueOrDefault(2000));
            }

            Console.WriteLine(filmes.ContainsValue("Wolverine"));

            Console.WriteLine($"Removeu? {filmes.Remove(2000)}");

            filmes.TryGetValue(2000, out string filme2000);
            Console.WriteLine($"Filme {filme2000}");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int,string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
