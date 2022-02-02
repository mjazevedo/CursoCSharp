﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7)); // Paramêtro Nomeado
        }
    }
}
