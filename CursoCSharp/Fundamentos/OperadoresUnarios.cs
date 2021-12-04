using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            //1º Operador Unário - Altera sinal do número
            Console.WriteLine(-ValorNegativo);

            //2º Operador Unário - Altera o valor lógico para negativo (NÃO)
            Console.WriteLine(!booleano);

            //3º Operador Unário - Incremento
            numero1++;
            Console.WriteLine(numero1);

            //3º Operador Unário - Decremento (com prioridade/precedência)
            --numero1;
            Console.WriteLine(numero1);

            //OBS
            Console.WriteLine(numero1++ == --numero2);
            /* Operador antes da variável = Procedência maior
             * 
             * Irá fazer a operação antes de realizar a comparação
             */
            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
