using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chamandoUmaArray
{
    class Program
    {
        static void Main(string[] args) {


            string produto = "A";
            string produto1 = "B";
            string produto2 = "C";


            string[] produtos = new string[5]{
            "a",
            "b",
            "c",
            "d",
            "f"
            };

            Console.WriteLine(produto);
            Console.WriteLine(produto1);
            Console.WriteLine(produto2);
            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine(produtos[3]);
            Console.WriteLine(produtos[4]);

            Console.ReadLine();

        }


    }
}
