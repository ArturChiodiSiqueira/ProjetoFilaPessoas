using System;

namespace ProjetoFilaPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoas contatos = new FilaPessoas();

            contatos.Print();//printa
            contatos.Pop();//remove
            contatos.Push(new Pessoa("morango", 32, "190"));//insere
            contatos.Push(new Pessoa("baratao", 47, "911"));//insere
            contatos.Print();//printa
            contatos.Length();//mostra quantidade
            contatos.Pop();//remove
            contatos.Print();//printa
            contatos.Pop();//remove
            contatos.Print();//printa
            contatos.Length();//mostra a quantidade
        }
    }
}
