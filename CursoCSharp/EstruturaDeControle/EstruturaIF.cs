using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            //int n1 = 5;
            //var n2 = 3;

            //if (n1 > n2)
            //{
            //    Console.WriteLine("Primeiro é maior.");
            //}
            //else
            //{
            //    Console.WriteLine("Segundo é maior.");
            //}

            //if (exp)
            //{
            //    Sentença;
            //    Sentença;
            //    Sentença;
            //}

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //{
            //    bomComportamento = true;
            //}

            //bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
