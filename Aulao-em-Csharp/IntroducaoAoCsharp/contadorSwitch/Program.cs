using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        //Repetindo no infinito
        int contador = 0;

        while (contador < 10) //Enquanto for verdade, faça
        {
            Console.WriteLine(contador);
            Console.WriteLine("Rodando programa");
        }

        Console.WriteLine("Fim da Linha");
        Console.ReadLine();
    }

    /*static void ParandoAContagem()
    {
        //Tornando o código finito
        int contador = 0;

        while (contador < 5)
        {
            Console.WriteLine(contador);
            Console.WriteLine("Rodando programa");
            contador = contador + 1; // Incrementa o valor do contador em cada iteração
        }

        Console.WriteLine("Contagem interrompida.");
        Console.ReadLine();
    }*/
}
