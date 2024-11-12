using Estagio.Tecnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Models;

public class SequenciaFibonacci(string texto)
{
    public int Numero { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Fibonacci { get; set; }
    public bool Pertence { get; set; } = false;
    public string Texto { get; set; } = texto;
    public void GetSequenciaFibonacci()
    {
        Numero = 21;
        X = 0;
        Y = 1;
        Fibonacci = 0;

        while (Fibonacci < Numero)
        {
            Fibonacci = X + Y;
            X = Y;
            Y = Fibonacci;

            if (Fibonacci == Numero)
            {
                Pertence = !Pertence;
                break;
            }
        }
    }
    public override string ToString()
    {
        string result = string.Empty;
        if (Pertence || Numero == 0)
        {
            result = $"{Numero} pertence à sequência.";
        }
        else
        {
            result = $"{Numero} não pertence à sequência.";  
        }

        Console.ForegroundColor = ConsoleColor.Green;
        return $"\n{HeaderLength.Length(Texto.Length)}" +
           $"\n{Texto}\n" +
           $"\n{result}" +
           $"\n{HeaderLength.Length(Texto.Length)}";
    }
}
