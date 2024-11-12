
using Estagio.Tecnica;
using System.Text;

namespace Estagio.Models;

public class FaturamentoDiario
{
    public FaturamentoDiario(string texto)
    {
        Texto = texto;
    }
    public Dictionary<string, decimal> FaturamentoMes { get; set; } = [];
    public StringBuilder DiasAcimaDaMedia {  get; set; } = new StringBuilder();
    public decimal MenorValorMes { get; set; }
    public decimal MaiorValorMes { get; set; }
    public decimal Media { get; set; }
    public string Texto { get; set; } = string.Empty;

    public void GetFaturamento()
    {
        FaturamentoDia();

        decimal soma = 0;
        
        foreach (var valor in FaturamentoMes.Values)
        {
            if (valor > 0)
            {
                soma += valor;
                if (valor < MenorValorMes)
                    MenorValorMes = valor;

                if (valor > MaiorValorMes)
                    MaiorValorMes = valor;
            }
        }

        Media = soma / FaturamentoMes.Count;

        DiasAcimaDaMedia = new StringBuilder();
        DiasAcimaDaMedia.AppendLine("Dias com faturamento acima da média:");

        foreach (var dia in FaturamentoMes)
        {
            if (dia.Value > Media)
            {
                DiasAcimaDaMedia.AppendLine($"{dia.Key} - Faturamento: {dia.Value}");
            }
        }
    }

    private void FaturamentoDia()
    {
        FaturamentoMes = new Dictionary<string, decimal>
        {
            { "Dia 1", 52340.0m },
            { "Dia 2", 0.0m },
            { "Dia 3", 4522.0m },
            { "Dia 4", 0.0m },
            { "Dia 5", 1250.0m },
            { "Dia 6", 4200.0m },
            { "Dia 7", 250.0m },
            { "Dia 8", 3000.0m },
            { "Dia 9", 15000.0m },
            { "Dia 10", 1000.0m },
            { "Dia 11", 7850.0m },
            { "Dia 12", 0.0m },
            { "Dia 13", 1450.0m },
            { "Dia 14", 6750.0m },
            { "Dia 15", 0.0m },
            { "Dia 16", 9800.0m },
            { "Dia 17", 4300.0m },
            { "Dia 18", 1200.0m },
            { "Dia 19", 2200.0m },
            { "Dia 20", 7100.0m },
            { "Dia 21", 0.0m },
            { "Dia 22", 600.0m },
            { "Dia 23", 5500.0m },
            { "Dia 24", 4500.0m },
            { "Dia 25", 980.0m },
            { "Dia 26", 2300.0m },
            { "Dia 27", 0.0m },
            { "Dia 28", 7000.0m },
            { "Dia 29", 8100.0m },
            { "Dia 30", 3650.0m }
        };

        MenorValorMes = decimal.MaxValue;
        MaiorValorMes = decimal.MinValue;
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n{HeaderLength.Length(Texto.Length)}" +
               $"\n{Texto}\n" +
               $"\nO menor valor de faturamento ocorrido em um dia do mês: {MenorValorMes}" +
               $"\nO maior valor de faturamento ocorrido em um dia do mês: {MaiorValorMes}" +
               $"\n{DiasAcimaDaMedia}" +
               $"{HeaderLength.Length(Texto.Length)}";
    }
}



