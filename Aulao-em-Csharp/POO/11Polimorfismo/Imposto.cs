using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Imposto
{

    //Metodos
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale Alimentação R$:"+(salario*0.1));
    }

    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale Transporte R$:"+(salario*0.06));
    }

}
