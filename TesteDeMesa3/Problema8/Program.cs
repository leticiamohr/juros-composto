using System;

namespace TesteDeMesa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valorInvestido = new double[3];
            double[] taxaJuros = new double[3];
            double[] rendimento = new double[3];
            double[] periodoMes = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 8.33 };
            double resgate = 0,
                   saldoLiq = 0;

            for (int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine($"Informe o valor[{cont + 1}] do investimento: ");
                valorInvestido[cont] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Informe o valor da taxa de juros[{cont + 1}]: ");
                taxaJuros[cont] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o valor do resgate no 5° mês: ");
            resgate = double.Parse(Console.ReadLine());

            for (int tabela = 0; tabela < 3; tabela++)
            {
                Console.WriteLine("Valor Investido | Taxa de Juros | Rendimento  | Período(Mês) | Saldo Líquido |\n" +
                "------------------------------------------------------------------------------");
                foreach (double mes in periodoMes)
                {
                    if (mes == 5)
                    {
                        Console.WriteLine($"-----------------------------Saque de {resgate:c}-----------------------------");
                        rendimento[tabela] -= resgate;
                        valorInvestido[tabela] = rendimento[tabela];
                        rendimento[tabela] = valorInvestido[tabela] * Math.Pow((1 + (taxaJuros[tabela] / 100)), mes);
                        saldoLiq = rendimento[tabela] - valorInvestido[tabela];
                    }
                    else
                    {
                        rendimento[tabela] = valorInvestido[tabela] * Math.Pow((1 + (taxaJuros[tabela] / 100)), mes);
                        saldoLiq = rendimento[tabela] - valorInvestido[tabela];
                    }
                    Console.WriteLine($"{valorInvestido[tabela]:c}     | {taxaJuros[tabela]}%            | {rendimento[tabela]:c} | {mes}            | {saldoLiq:c}    |");
                }
                Console.WriteLine(" \n \n ");
            }
        }
    }
}