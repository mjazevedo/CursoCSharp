using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int num)
        {
            num = num + 1000;
        }

        public static void AlterarOut(out int num1, out int num2)
        {
            num1 = 0;
            num2 = 0;
            num1 = num1 + 15;
            num2 = num2 + 30;
        }
        public static void Executar()
        {
            int a = 13;
            AlterarRef(ref a);
            Console.WriteLine(a);

            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
