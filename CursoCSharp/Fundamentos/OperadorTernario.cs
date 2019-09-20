using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            
            //Ternario pq tem 3 condição
            //var nota = 7.0;
            //string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            //Console.WriteLine(resultado);

            //outro exemplo
            var nota = 6.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ?
                "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
