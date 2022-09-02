using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilaPessoas
{
    internal class FilaPessoas
    {
        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }

        public FilaPessoas()
        {
            HEAD = TAIL = null;
        }

        public void Push(Pessoa aux)
        {
            if (Vazia())
            {
                HEAD = TAIL = aux;
            }
            else
            {
                TAIL.Proximo = aux;
                TAIL = aux;
            }
            Console.WriteLine("Inserido com sucesso!");
            Console.ReadKey();
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel remover. Fila vazia!");
            }
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == null)
                {
                    TAIL = null;
                }
                Console.WriteLine("Elemento removido!");
            }
            Console.ReadKey();
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                Pessoa aux = HEAD;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO");
            }
            Console.ReadKey();
        }

        public void Length()
        {
            int contador = 0;
            if (Vazia())
                Console.WriteLine("Fila vazia! Sem nenhum elemento.");
            else
            {
                Pessoa aux = HEAD;
                do
                {
                    contador++;
                    aux = aux.Proximo;

                } while (aux != null);
                Console.WriteLine("A fila tem " + contador + " elemento(s).");
                Console.ReadKey();
            }
        }

        private bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
