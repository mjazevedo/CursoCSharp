using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arrList.Add(3.14);

            foreach (var item in arrList)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
