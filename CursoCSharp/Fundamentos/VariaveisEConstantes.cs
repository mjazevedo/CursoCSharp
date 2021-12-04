using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área de circunferência
            double raio = 4.5;
            const double PI = 3.14;
            /* C# é fortemente tipada
             * Nomes claros para variáveis
             * Não usar nomes reservados da linguagem
             */

            raio = 5.5;
            // PI = 3.14159;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            Console.WriteLine("Área é " + area + 1000);
            Console.WriteLine("Área é " + (area + 1000));

            //Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            int menorValorInt = int.MinValue; // Mais usados do inteiros !
            Console.WriteLine("Menor inteiro " + menorValorInt);

            uint populaçaoBrasileira = 207_600_000;
            // letra U = Apenas números positivos
            // Questão de clareza: Utilizar underline para separar as casas de um número
            Console.WriteLine("População Brasileira " + populaçaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usados dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Valores muito grandes
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; // Única letra = Aspas simples
            Console.WriteLine("Letra " + letra);

            string texto = "Seu texto aqui !";
            Console.WriteLine(texto);

        }
    }
}
