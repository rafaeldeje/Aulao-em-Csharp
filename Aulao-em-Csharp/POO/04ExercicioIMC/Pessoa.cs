using System;

class Pessoa
{
    public double peso;
    public double altura;
    public double imC;

    public void classificarIMC()
    {
        if (imC < 18)
        {
            Console.WriteLine("Você está abaixo do peso");
        }
        else if (imC < 25)
        {
            Console.WriteLine("Você está com peso normal");
        }
        else if (imC < 30)
        {
            Console.WriteLine("Você está acima do seu peso");
        }
        else if (imC < 35)
        {
            Console.WriteLine("Obesidade 1");
        }
        else if (imC < 40)
        {
            Console.WriteLine("Obesidade 2");
        }
        else
        {
            Console.WriteLine("Obesidade 3");
        }
    }

    public void mensagem()
    {
        Console.WriteLine("Seu peso dividido " + peso + " com (" + altura + " vezes " + altura + "), dá: " + imC);
    }
}