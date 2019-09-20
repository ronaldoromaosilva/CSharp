using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControles
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o numero que queremos? ", 1);
                if (i == numero)
                {
                    Console.WriteLine("sim!");
                    break;

                } else
                {
                   Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
