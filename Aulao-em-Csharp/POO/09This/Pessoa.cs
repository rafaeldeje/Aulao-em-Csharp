using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Atributos
public class Pessoa
{
 private string nome = "Thais";

 //Construtor
 public Pessoa (string nome)
 {
    Console.WriteLine(nome);
    Console.WriteLine(this.nome);

 }
}
