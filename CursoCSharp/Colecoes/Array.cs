using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = {"Anderson", "Bia", "Carlos", "Daniela", "Emanuel"};

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double sum = 0;
            double[] notas = {9.7, 4.8, 8.4, 8.2, 6.8};

            foreach(var nota in notas)
            {
                sum += nota;
            }

            //for(int i = 0; i < notas.Length; i++)
            //{
            //    sum += notas[i];
            //}

            double media = sum / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
