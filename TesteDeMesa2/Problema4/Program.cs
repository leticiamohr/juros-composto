using System;

namespace problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 2000,
                   taxaJuros = 2,
                   rendimento = 0,
                   rendaLiquida = 0,
                   rendaAcumulada = valorPresente,
                   saldo = 0,
                   resgate = 1000;
            int periodoMes = 6;

            Console.WriteLine("Valor Presente | Taxa de Juros | Mês |  Rendimento | Renda Líquida | Renda Acumulada |    Saldo    |\n" +
                "----------------------------------------------------------------------------------------------------");

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                if (mes == 5)
                {
                    Console.WriteLine($"----------------------------------------Saque de: {resgate:c}----------------------------------------");
                    rendaAcumulada -= resgate;
                    valorPresente = rendaAcumulada;
                    rendimento = CalculoRendimento(mes, taxaJuros, valorPresente);
                    rendaLiquida = rendimento - valorPresente;
                    rendaAcumulada = valorPresente + rendaLiquida;
                    saldo = rendaAcumulada;
                }
                else
                {
                    rendimento = CalculoRendimento(mes, taxaJuros, valorPresente);
                    rendaLiquida = rendimento - valorPresente;
                    rendaAcumulada = valorPresente + rendaLiquida;
                    saldo = rendaAcumulada;
                }
                Console.WriteLine($"{valorPresente:c}    | {taxaJuros}%            |  {mes}  | {rendimento:c} | {rendaLiquida:c}      | {rendaAcumulada:c}     | {saldo:c} |");
            }
        }
        static double CalculoRendimento(int mes, double taxaJuros, double valorPresente)
        {
            return valorPresente * Math.Pow((1 + (taxaJuros / 100)), mes);
            //return valorPresente * (1 + (taxaJuros / 100) * mes);
        }
    }
}