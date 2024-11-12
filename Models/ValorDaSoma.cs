using Estagio.Tecnica;

namespace Estagio.Models;

public class ValorDaSoma(string texto)
{
    public int Indice { get; set; }
    public int Soma { get; set; }
    public int K { get; set; }
    public string Texto { get; set; } = texto;
    public void GetSoma()
    {
        Indice = 13;

        while (K < Indice)
        {
            K++;
            Soma += K;
        }
    }
    public override string ToString()
    {
        return $"{HeaderLength.Length(Texto.Length)}" +
            $"\n{Texto}" +
            $"\nA soma {Soma}" +
            $"\n{HeaderLength.Length(Texto.Length)}";
    }
}
