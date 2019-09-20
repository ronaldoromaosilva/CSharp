using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {

            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            //transforma "1" => 1 se tiver "opa" => 1 dar problema na conversao
            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            //double salario = double.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //interpolção que usamos na aula anterior
            Console.WriteLine($"{nome} {idade} R${salario}");

            
        }
    }
}
