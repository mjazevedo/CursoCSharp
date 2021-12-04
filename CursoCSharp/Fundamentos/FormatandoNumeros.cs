using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            // CTRL + TAB = Navegar entre abas
            // CTRL + Espaço = Completa código

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Indica a quantidade de casas decimais
            Console.WriteLine(valor.ToString("#.##")); // Indica a quantidade de casas decimais
            Console.WriteLine(valor.ToString("C")); // Formata para moeda atual
            Console.WriteLine(valor.ToString("P")); // Percentual

            //Configurando a região e sua moeda corrente

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Completa com 0 à esquerda até ficar com 10 posições

        }
    }
}
