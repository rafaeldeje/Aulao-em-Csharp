using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale Alimentação R$:" + (salario * 0.12));
    }

}
