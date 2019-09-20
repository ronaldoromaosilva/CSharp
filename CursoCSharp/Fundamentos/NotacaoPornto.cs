using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPornto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!");
            var saudacao2 = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
          
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao2);
            Console.WriteLine("Teste".Length);

            //cuidade para usar notação ponto para coisas que estão vazias
            //string valorImportante = null;
            //Console.WriteLine(valorImportante.Length);

            //com a interrogacao nao deixa acessar o Length em caso de vazia
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);




        }
    }
}
