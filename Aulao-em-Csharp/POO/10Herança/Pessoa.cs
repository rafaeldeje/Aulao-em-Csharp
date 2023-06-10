using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Herança
{
    public class Pessoa
    {
        //Atributos
        protected string nome;
        //apenas a classe que é criado aquele atributo ou metodo pode usar, alem classes que vao herdar
        protected int idade;

        //Metodo
        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}