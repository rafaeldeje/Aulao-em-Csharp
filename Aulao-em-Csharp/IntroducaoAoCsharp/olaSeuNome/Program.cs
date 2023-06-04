using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class olaSeuNome
    {
        static void Main(string[] args)
        {
            //Capturando o que o Usuário digita.
            String nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();

            /*na linha 14 definimos a string nome em espaço vazio, para que na linha 16 seja defenida pela usuario.*/
        }
    }
}
