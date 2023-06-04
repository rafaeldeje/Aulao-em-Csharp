using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usandoEnum
{
    static class Program
    {
        enum Cores { Vermelho, Laranja, Amarelo, Verde, Azul, Anil, Violeta }
        static void Main(string[] args)
        {

            Cores primeiraCorDoArcoIris = Cores.Vermelho;  
            Cores segundaCorDoArcoIris = Cores.Laranja;
            Cores terceiraCorDoArcoIris = Cores.Amarelo;
            Cores quartaCorDoArcoIris = Cores.Verde;
            Cores quintaCorDoArcoIris = Cores.Azul;
            Cores sextaaCorDoArcoIris = Cores.Anil;
            Cores setimaCorDoArcoIris = Cores.Violeta;


            Console.WriteLine(primeiraCorDoArcoIris);
            Console.WriteLine((int)segundaCorDoArcoIris);
            Console.WriteLine(terceiraCorDoArcoIris);
            Console.WriteLine((int)quartaCorDoArcoIris);
            Console.WriteLine(quintaCorDoArcoIris);
            Console.WriteLine((int)sextaaCorDoArcoIris);
            Console.WriteLine(setimaCorDoArcoIris);

            Console.ReadLine();

        }
    }
}
