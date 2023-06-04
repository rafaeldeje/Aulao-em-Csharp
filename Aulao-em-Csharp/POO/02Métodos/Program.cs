using System;

namespace _02Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Pessoa obj = new Pessoa ();
        obj.apresentar();
        obj.apresentar("rafael");
        obj.apresentar("Rafael", 27);


        }
    }
}