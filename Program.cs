using Estagio.Models;

var teste01 = new ValorDaSoma("Teste 01 - Soma");
teste01.GetSoma();
Console.WriteLine(teste01);

var teste02 = new SequenciaFibonacci("Teste 02 - Sequencia de Fibonacci");
teste02.GetSequenciaFibonacci();
Console.WriteLine(teste02);

var teste03 = new FaturamentoDiario("Teste 03 - O valor de faturamento diário de uma distribuidora.");
teste03.GetFaturamento();
Console.WriteLine(teste03);

Console.ResetColor();