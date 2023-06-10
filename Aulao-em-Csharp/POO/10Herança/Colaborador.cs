using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Herança
{
    public class Colaborador : Pessoa //: Cria a herança entre as classes
    {
        //Atributos
        private double salario;

        //Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;


            mensagemPessoa();
            mensagemColaborador();
        }

        //Metodo
        private void mensagemColaborador()
        {
            Console.WriteLine("Salario: " + salario);
        }
    }
}