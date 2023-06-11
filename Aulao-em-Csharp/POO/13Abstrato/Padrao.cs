using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public abstract class Padrao
{
    // Obrigatório
    public abstract void taxaEmprestimo(double valor);

    // Opcional
    public void calculoPoupança(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
    }
}

