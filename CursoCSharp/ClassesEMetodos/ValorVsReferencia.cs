using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    //public struct Dependente
    //{
    //    public string Nome;
    //    public int Idade;
    //}
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int num = 3;
            int copiaNum = num;

            Console.WriteLine($"{num} {copiaNum}");

            num++;
            Console.WriteLine($"{num} {copiaNum}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Matheus";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
