using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Caneta
{

    public string nome;
    public string cor;

    public void apresentacao()
    {
        Console.WriteLine("A cor da minha " + nome + " é " + cor + "!!!");
        Console.ReadLine();
    }
}