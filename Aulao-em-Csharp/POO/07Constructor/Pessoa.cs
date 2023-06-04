using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07Constructor
{
    public class Pessoa
    {
        //Construtor

        public Pessoa()
        {
            Console.WriteLine("Constutor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá "+nome);
        }
    }
}