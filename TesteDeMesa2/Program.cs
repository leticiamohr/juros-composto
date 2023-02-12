using System;

namespace testeMesa2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            double valorPresente = 1000,
                   taxaJuros = 5.3,
                   valorFuturo = 0,
                   percentualJuros = 0;
            int periodoMes = 6;

            valorFuturo = valorPresente * Math.Pow((1 + (taxaJuros / 100)), periodoMes);
            percentualJuros = Math.Round(((valorFuturo - valorPresente) * 100) / valorFuturo);

            Console.WriteLine(
                $"Valor Presente = {valorPresente:c}\n" +
                $"Taxa de Juros = {taxaJuros}%\n" +
                $"Período(mês) = {periodoMes} meses\n" +
                $"Valor Futuro = {valorFuturo:c}\n" +
                $"Percentual de juros: {percentualJuros}%"
            );
        }
    }
}