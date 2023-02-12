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
            double[] periodoMes = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 8.33 };
            double resgate = 0;

            for (int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine($"Informe o valor[{cont + 1}] do investimento: ");
                valorPresente[cont] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Informe o valor da taxa de juros[{cont + 1}]: ");
                taxaJuros[cont] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o valor do resgate no 5° mês: ");
            resgate = double.Parse(Console.ReadLine());

            for (int tabela = 0; tabela < 3; tabela++)
            {
                Console.WriteLine("Valor Presente | Período(Mês) | Taxa de Juros | Valor Futuro |\n" +
                "--------------------------------------------------------------");
                foreach (double mes in periodoMes)
                {
                    if (mes == 5)
                    {
                        Console.WriteLine($"---------------------Saque de {resgate:c}---------------------");
                        valorFuturo[tabela] -= resgate;
                        valorPresente[tabela] = valorFuturo[tabela];
                        valorFuturo[tabela] = valorPresente[tabela] * Math.Pow((1 + (taxaJuros[tabela] / 100)), mes);
                    }
                    else
                    {
                        valorFuturo[tabela] = valorPresente[tabela] * Math.Pow((1 + (taxaJuros[tabela] / 100)), mes);
                    }
                    Console.WriteLine($"{valorPresente[tabela]:c}    | {mes}            | {taxaJuros[tabela]}%            | {valorFuturo[tabela]:c}  |");
                }
                Console.WriteLine(" \n \n ");
            }
        }
    }
}