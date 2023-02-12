using System;

namespace problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 3800,
                   taxaJuros = 1.25,
                   rendimento = 0,
                   rendLiq = 0,
                   saque = 1000,
                   rendaAcumulada = valorPresente;
            int periodoMes = 6;

            Console.WriteLine("Mês | Valor Presente | Taxa de Juros | Rendimento  | Rendimento Líquido | Renda Acumulada |\n" +
                "-------------------------------------------------------------------------------------------");

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                if (mes == 5)
                {
                    Console.WriteLine($"------------------------------------Saque de: {saque:c}-----------------------------------");
                    rendaAcumulada -= saque;
                    valorPresente = rendaAcumulada;
                    rendimento = valorPresente * Math.Pow((1 + (taxaJuros / 100)), mes);
                    rendLiq = rendimento - valorPresente;
                    rendaAcumulada = valorPresente + rendLiq;
                }
                else
                {
                    rendimento = valorPresente * Math.Pow((1 + (taxaJuros / 100)), mes);
                    rendLiq = rendimento - valorPresente;
                    rendaAcumulada += rendLiq;
                }
                Console.WriteLine($"{mes}   | {valorPresente:c}    | {taxaJuros}%         | {rendimento:c} | {rendLiq:c}           | {rendaAcumulada:c}     |");
            }
        }
    }
}