using System;

class Pessoa
{

    //Atributos
    public string nome;
    public int idade;

    //Métodos
    public void apresentacao()
    {
        Console.WriteLine("Olá! " + nome + ", você tem " + idade + " anos!");
        Console.ReadLine();
    }
}
