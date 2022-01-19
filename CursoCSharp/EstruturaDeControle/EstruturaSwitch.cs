using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimentoo com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 1:
                    Console.WriteLine("Péssimo");
                    break; //Sair da estrutura e vai para a linha seguinte
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular!");
                    break;
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                case 5:
                    Console.WriteLine("Ótimo!");
                    break;
                default: //caso não for nenhum do valores de case
                    Console.WriteLine("Nota inválida!");
                    break;
            }       

            Console.WriteLine("Fim!");
            Console.ReadLine();
        }
    }
}
