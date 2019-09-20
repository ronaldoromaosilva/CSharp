using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CalssesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar a veriável 'a' dentro do método Executar!
            //Console.WriteLine(a);

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

        }
    }
}
