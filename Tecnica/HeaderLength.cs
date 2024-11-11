using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Tecnica;

public static class HeaderLength
{
    private static void Length(int tamanho)
    {
        string header = string.Empty;
        for (int i = 0; i < tamanho; i++)
        {

            header += "-";
        }

        Console.WriteLine(header);
    }
    public static void Header(int tamanho)
    {
        Length(tamanho);
    }
    public static void Exit(int tamanho)
    {
        Length(tamanho);
        Console.WriteLine("\n");
        return;
    }
}
