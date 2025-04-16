using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Pessoa
    {
        public string nome;
        public string Nome
        {
            get { return nome; }

            set {
                if (value.Length > 0) {
                    nome = value.ToUpper();
                } else {
                    Console.WriteLine("nome invalido")
                }
            }
        }
        protected string email;
        public string Email
        {
            get { return email.ToUpper(); }
            set { email = value; }
        }

        public void exibirDados() {
            Console.WriteLine("O seu nome é: {0}", Nome);
            Console.WriteLine("O seu email é: {1}",Email);

        }

        public virtual void cadastrar() { 
            Console.WriteLine("Digite seu nome:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu e-mail:");
            this.Email = Console.ReadLine();
        }
    }
}
