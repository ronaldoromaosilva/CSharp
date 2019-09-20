using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEContantes
    {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //Valor da variavel constante nao da pra mudar
            //PI = 3.1415;

            //Existe função que eleva ao quadrado
            double area = PI * raio * raio;

            Console.WriteLine(area);

            //Concatenaçao + -> para juntar
            Console.WriteLine("Area é " + area + 10000);

            //Colocando ele como soma
            Console.WriteLine("Area é " + (area + 10000));

            //Tipos interno

            //bool é verdadeiro ou false
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario );

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            //O F no final indica o tipo float, sem ele vira double
            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do Computador " + precoComputador );

            double valorDeMercadorDaApple = 1_000_000_000.00; //Mais usado dos reais
            Console.WriteLine("Valor Apple" + valorDeMercadorDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            // para uma unica letra
            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            // Cadeia de caracteres
            string texto = "Seja bem vindo ao Curso C#";
            Console.WriteLine(texto);

            










        }
    }
}
