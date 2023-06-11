using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Juridica R$ " + (valor * 0.2));
    }

}