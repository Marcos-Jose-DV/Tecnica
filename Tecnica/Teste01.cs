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
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Teste 01 - Soma");
        Console.WriteLine(soma);
        Console.WriteLine("---------------\n\n");
    }
}
