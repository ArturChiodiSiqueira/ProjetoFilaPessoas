using System;

namespace ProjetoFilaPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoas contatos = new FilaPessoas();

            contatos.Print();
            contatos.Pop();
            contatos.Push(new Pessoa("morango", 32, "190"));
            contatos.Push(new Pessoa("baratao", 47, "911"));
            contatos.Print();
            contatos.Length();
            contatos.Pop();
            contatos.Print();
            contatos.Pop();
            contatos.Print();
            contatos.Length();
        }
    }
}
