using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {   //Conversão implícita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // Casting - Conversão Explícita
            Console.WriteLine("Nota truncada = {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Converter string para número -  gera um valor 0 se for string
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado 1: {0}", numero);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);

        }

    }
}
