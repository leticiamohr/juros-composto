using System;

namespace problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 0,
                   taxaJuros = 10,
                   valorFuturo = 7390.61,
                   rendLiq = 0,
                   rendaAcumulada = valorPresente;
            int periodoAno = 2;

            Console.WriteLine("Período(Ano) | Taxa de Juros | Valor Futuro | Valor Presente | Rendimento Líquido | Renda Acumulada |\n" +
                "-----------------------------------------------------------------------------------------------------");

            valorPresente = valorFuturo / Math.Pow((1 + (taxaJuros / 100)), periodoAno);
            rendLiq = valorFuturo - valorPresente;
            rendaAcumulada = valorPresente + rendLiq;
            Console.WriteLine($"{periodoAno}            | {taxaJuros}%           | {valorFuturo:c}  | {valorPresente:c}    | {rendLiq:c}        | {rendaAcumulada:c}     |");
        }
    }
}