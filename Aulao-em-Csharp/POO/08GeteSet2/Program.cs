namespace _08GeteSet2;


public class Program
{
    static void Main()
    {
        CaixaMagica caixa = new CaixaMagica(); // Criando uma instância da classe CaixaMagica

        // Obtendo a cor atual da caixa
        string corAtual = caixa.Cor;
        Console.WriteLine("A cor atual da caixa é: " + corAtual);

        // Definindo uma nova cor para a caixa
        caixa.Cor = "verde";
        Console.WriteLine("A cor da caixa foi alterada para: " + caixa.Cor);
    }
}

