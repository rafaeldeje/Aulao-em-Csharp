using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Tornando o código finito
        int contador = 0;

        while (contador < 5)
        {
            Console.WriteLine(contador + 1);
            Console.WriteLine("Rodando programa");
            //contador contador + 1;
            //contador += 1;
            contador = contador ++;
            // Incrementa o valor do contador em cada iteração
        }

        do
        {
            Console.WriteLine("do while");
        } while (12 < 10);

        //Console.WriteLine("Contagem interrompida.");
        //Console.ReadLine();

        // Loop do-while removido

        Console.Write("Fim da linha");
        Console.ReadLine();
    }
}
