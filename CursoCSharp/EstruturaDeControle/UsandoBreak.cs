using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int num = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {num}");

            for(int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);

                if(i == num)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
        }
    }
}
