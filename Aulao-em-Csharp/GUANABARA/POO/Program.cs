using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        // Instanciando um objeto
        Caneta obj = new Caneta();
        obj.nome = "caneta Bic";
        obj.cor = "azul";
        obj.apresentacao();
        // Apresentar na outra interface
    }
}