using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Tecnica;

public static class Teste02
{
    public static void SequenciaFibonacci()
    {
        string texto = "Teste 02 - Sequencia de Fibonacci";
        HeaderLength.Header(texto.Length);
        Console.WriteLine(texto);

        int num = 21;
        int a = 0, b = 1, f = 0;

        while (f < num)
        {
            f = a + b;
            a = b;
            b = f;
        }

        if (f == num || num == 0)
        {
            Console.WriteLine($"{num} pertence à sequência.");
        }
        else
        {
            Console.WriteLine($"{num} não pertence à sequência.");
        }
        HeaderLength.Exit(texto.Length);
    }
}
