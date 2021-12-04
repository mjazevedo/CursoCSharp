using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10.0}");
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Nota perfeita? {0}", nota == 0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Está de recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine($"Reprovado? {nota <= 3.0}");
        }
    }
}
