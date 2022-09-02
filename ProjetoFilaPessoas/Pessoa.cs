using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilaPessoas
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa(string nome, int idade, string telefone)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
            Proximo = null;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade:" + Idade + "\nTelefone: " + Telefone;
        }
    }
}