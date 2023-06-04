using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasCondicionais
{
    public class estruturasCondicionais
    {

        //Festa:
        //Só pode entrar na festa se for mulher e for acima de 25 anos.
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à festa!");
            Console.WriteLine("Qual é o seu gênero? (Digite 'M' para mulher ou 'H' para homem)");
            char genero = Console.ReadKey().KeyChar;
            Console.WriteLine("\nQual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (genero == 'H' || genero == 'h')
            {
                Console.WriteLine("Você é homem, não pode entrar, só muie");
            }else if (genero == 'M' && idade >= 25)
            {
                Console.WriteLine("Bem-vinda à festa!");
            }
            else if (idade >= 25)
            {
                Console.WriteLine("Bem-vindo à festa!");
            }
            else
            {
                Console.WriteLine("Desculpe, você não pode entrar na festa.");
                /*Explicação do código:

     A primeira linha importa o namespace System, que contém as classes fundamentais do C#.
     Em seguida, definimos uma classe chamada Program.
     Dentro da classe Program, definimos um método Main, que é o ponto de entrada do programa.
     Dentro do método Main, exibimos uma mensagem de boas-vindas à festa.
     Pedimos ao usuário para digitar seu gênero, lendo um caractere do teclado usando o método ReadKey da classe Console.
     Pedimos ao usuário para digitar sua idade, lendo um número inteiro do teclado usando o método ReadLine da classe Console e convertendo-o para um inteiro usando o método int.Parse().
     Usamos uma estrutura condicional para verificar se o gênero do usuário é 'M' e se sua idade é maior ou igual a 25.
     Se a condição for verdadeira, exibimos uma mensagem de boas-vindas para mulheres.
     Se a condição não for verdadeira, verificamos se a idade do usuário é maior ou igual a 25.
     Se a condição for verdadeira, exibimos uma mensagem de boas-vindas para homens.
     Se a condição não for verdadeira, exibimos uma mensagem dizendo que o usuário não pode entrar na festa.*/
            }

        }
    }
}