using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Tecnica;

public static  class HeaderLength
{
    public static string Length(int tamanho)
    {

        string header = string.Empty;
        for (int i = 0; i < tamanho; i++)
        {
            header += "-";
        }
        return header;
    }
}
