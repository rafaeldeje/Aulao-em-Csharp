using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usandoEnumEmUmMenu
{
    static class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            //Captura o numero digitado do usuario

            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Criando arquivo.../");
                    Console.ReadLine();
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletando arquivo.../");
                    Console.ReadLine();
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editando arquivo.../");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("O item selecionado não existe!");
                    break;
            }


            Console.WriteLine(opcaoSelecionada);

            Console.ReadLine();


        }

    }
}
