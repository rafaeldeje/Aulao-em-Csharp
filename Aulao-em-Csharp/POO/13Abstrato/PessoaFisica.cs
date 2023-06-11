using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class PessoaFisica : Padrao
{

    //Metodo obrigatório

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Fisica R$ " + (valor * 0.1));
    }

}
