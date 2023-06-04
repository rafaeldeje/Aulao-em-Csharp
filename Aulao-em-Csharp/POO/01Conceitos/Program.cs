using System;

class Program
{
    static void Main(string[] args)
    {
        //Instanciar um objeto
        Pessoa obj = new Pessoa();
        obj.nome = "Rafael";
        obj.idade = 28;
        obj.apresentacao();
        //chama o método apresentacao() da classe Pessoa
    }
}
