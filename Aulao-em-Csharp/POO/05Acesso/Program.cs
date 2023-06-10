namespace _05Acesso;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        p.nome = "rafael";
        //p.valor = 11; ("Produto.valor" é inacessível devido ao seu nível de proteção)
        //p.valor nao mostra
    }
}
