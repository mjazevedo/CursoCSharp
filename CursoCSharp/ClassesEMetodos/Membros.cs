using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Idade = 21;
            fulano.Nome = "João";

            //Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos.");

            //fulano.ApresentarNoConsole();

            var sicrano = new Pessoa();

            sicrano.Nome = "Maria";
            sicrano.Idade = 21;

            var apresentacaoFulano = sicrano.Apresentar();
        }
    }
}
