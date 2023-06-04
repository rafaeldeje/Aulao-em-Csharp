using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    public class Aluno
    {
        //Atributos
        private double nota1, nota2;

        //Média
        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Mensagem
        public void mensagem()
        {
            Console.WriteLine("Informe a sua primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a sua segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua média é "+media());
        }



    }
}