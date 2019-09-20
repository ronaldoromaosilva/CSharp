using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            //converte de double para string
            Console.WriteLine(valor.ToString("F1"));

            //converte para valor monetário
            Console.WriteLine(valor.ToString("C"));

            //converte para percentual - multiplicou por 100
            Console.WriteLine(valor.ToString("P"));

            //seria a mesma coisa de usa F2
            Console.WriteLine(valor.ToString("#.##"));

            //pode alterar por outros paises "en-US"  "pt-BR" C1 C3
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            //completar com 0 a direita
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            

      
        }
    }
}
