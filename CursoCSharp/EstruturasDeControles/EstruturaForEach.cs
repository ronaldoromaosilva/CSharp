using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControles
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
               Console.Write(letra);
                
            }
            Console.WriteLine();

            var alunos = new string[] { "Ana", "Bia", "carlos" };
            
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
