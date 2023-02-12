using System;

namespace TesteDeMesa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valorPresente = new double[3];
            double[] taxaJuros = new double[3];
            double[] valorFuturo = new double[3];
            double periodoMes = 8.33;

            for (int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine($"Informe o valor[{cont + 1}] do investimento: ");
                valorPresente[cont] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Informe o valor da taxa de juros[{cont + 1}]: ");
                taxaJuros[cont] = double.Parse(Console.ReadLine());

                valorFuturo[cont] = valorPresente[cont] * Math.Pow((1 + (taxaJuros[cont] / 100)), periodoMes);
            }

            Console.WriteLine("Valor Presente | Período(Mês) | Taxa de Juros | Valor Futuro |\n" +
                "--------------------------------------------------------------");

            for (int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine($"{valorPresente[cont]:c}    | {periodoMes}         | {taxaJuros[cont]}%            | {valorFuturo[cont]:c}  |");
            }
        }
    }
}