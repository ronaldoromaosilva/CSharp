using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CalssesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiarNumero = numero;
            Console.WriteLine($"{numero} {copiarNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiarNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");


        }
    }
}
