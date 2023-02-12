using System;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 0,
                   taxaJuros = 0,
                   periodoAno = 0,
                   valorFuturo = 0;

            Console.WriteLine("Informe o valor de investimento inicial:");
            valorPresente = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a taxa de juros:");
            taxaJuros = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o período (a.a):");
            periodoAno = double.Parse(Console.ReadLine());

            valorFuturo = valorPresente * Math.Pow((1 + (taxaJuros / 100)), periodoAno);
            Console.WriteLine(
                $"O investimento inicial é de {valorPresente:c}\n" +
                $"A taxa de juros é de {taxaJuros}% ao ano.\n" +
                $"O período é de {periodoAno} anos.\n" +
                $"O valor futuro será {valorFuturo:c}"
            );
        }
    }
}