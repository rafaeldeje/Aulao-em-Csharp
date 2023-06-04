using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
 static void Main(string[] args)
    {

        string[] palavras = { "victor", "rafael", "thais", "liduina"};

        foreach (string palavra in palavras)
            //Para cada palavra no array palavras, repita o bloco de codigo
        {
            Console.WriteLine(palavra);
        }


        Console.WriteLine("fim da linha");
        Console.ReadLine();

    }
}
