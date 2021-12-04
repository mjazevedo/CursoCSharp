using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            // && operador lógico "E"
            // || operador lógico "OU"
            // ! operador lógico "NÃO"
            // ^ operador lógico "OU EXLCUSIVO"

            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou a TV 32? {comprouTv32} ");

            Console.WriteLine($"Mais saúdável? {!comprouSorvete} "); // Operador Unário
        }
    }
}
