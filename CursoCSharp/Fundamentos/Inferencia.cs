using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class Inferencia {


        public static void Executar() {
            var nome = "Leonardo";
            // nome = 123; nao pode fazer isso
            Console.WriteLine(nome);

            // int idade ou inicializa a variavel
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 2;

            Console.WriteLine(a + b);

            
        }
    }
}
