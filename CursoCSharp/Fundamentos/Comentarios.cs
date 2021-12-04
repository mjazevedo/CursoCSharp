using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// 
    /// </summary>
    class Comentarios
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// 
        /// CRTL + Espaço = tags em XML

        public static void Executar()
        {
            // Comentário de 1 linha
            // Cuidado com os coemtários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            Console.WriteLine("O C# tem o XML Comments");

            /*
             * 
             * Esse é um comentário de multíplas linhas
             * 
             * Não precisa destes asteriscos à esquerda
             * 
             */

            Console.WriteLine("1");
            Console.WriteLine("2");

            // CTRL + K + C = Comenta tudo selecionado
            // CTRL + K + U = Descomenta tudo selecionado

            /* Senão for o comando acima:
             * 
             * Editar > Avançado > Definir Seleção como Comentário e Remover definição de seleção como Comentário
             * 
             */
        }
    }
}
