namespace _04ExercicioIMC;
class Program
{
    static void Main(string[] args)
    {
        Pessoa a = new Pessoa();
        a.peso = 114.5;
        a.altura = 1.93;
        a.imC = a.peso / (a.altura * a.altura);
        a.mensagem();
        a.classificarIMC();
    }
}