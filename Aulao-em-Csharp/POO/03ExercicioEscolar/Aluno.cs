using System;
//Função

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    
    //Média
    public double media ()
    {
        return (nota1+nota2)/2;

    }

    //Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }


    //Mensagem
    public void mensagem ()
    {
        //Obter a média
        double obterMedia = media();

        //Obter a situacao
        string obterSituacao = situacao(obterMedia);
        Console.Write(nome+" está "+obterSituacao+" com a média de "+obterMedia);
    }
}
