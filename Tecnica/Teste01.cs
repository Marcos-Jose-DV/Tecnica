using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Tecnica;

public static class Teste01
{
    public static void ValorDaSoma()
    {
        string texto = "Teste 01 - Soma";
        HeaderLength.Header(texto.Length);
        Console.WriteLine(texto);

        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine(soma);
        HeaderLength.Exit(texto.Length);
    }
}
