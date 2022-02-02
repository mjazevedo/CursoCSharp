using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class StructVsClasse
    {
        public struct Sponto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            Sponto p1 = new Sponto
            {
                X = 1,
                Y = 3
            };

            Sponto copiap1 = p1; // Atribuição por VALOR !!!
            p1.X = 3;

            Console.WriteLine("Utilizando Struct:");
            Console.WriteLine("Ponto 1 X: {0}", p1.X);
            Console.WriteLine("Cópia Ponto 1 X: {0}", copiap1.X);
            Console.WriteLine();


            CPonto p2 = new CPonto
            {
                X = 2, Y = 4
            };
            CPonto copiap2 = p2; // Atribuição por REFERÊNCIA !!!
            p2.X = 5;

            Console.WriteLine("Utilizando Classe:");
            Console.WriteLine("Ponto 2 X: {0}", p2.X);
            Console.WriteLine("Cópia Ponto 2 X: {0}", copiap2.X);

        }
    }
}
