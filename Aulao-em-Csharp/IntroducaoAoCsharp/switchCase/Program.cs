using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma cor do arco-íris:");
            string cor = Console.ReadLine().ToLower();

            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Você escolheu a cor vermelha");
                    break;
                case "amarelo":
                    Console.WriteLine("Você escolheu a cor amarelo");
                    break;
                case "laranja":
                    Console.WriteLine("Você escolheu a cor laranja");
                    break;
                case "verde":
                    Console.WriteLine("Você escolheu a cor verde");
                    break;
                case "azul":
                    Console.WriteLine("Você escolheu a cor azul");
                    break;
                case "anil":
                    Console.WriteLine("Você escolheu a cor anil");
                    break;
                case "violeta":
                    Console.WriteLine("Você escolheu a cor violeta");
                    break;
                default: 
                    Console.WriteLine("Sua cor não existe no arcoiris");
                    break;




            }

        }
    }
}
