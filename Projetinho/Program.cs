using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Buru";
            pessoa.Email = "buruintheworld@2007.com";
            Console.WriteLine("nome: {0}", pessoa.Nome);
            Console.WriteLine(pessoa.Email);
            Cliente cliente = new Cliente();
            cliente.cadastrar();
            cliente.exibirCliente();
            Gerente gerente = new Gerente();
            gerente.cadastrar();
            gerente.exibirSetor();
            Funcionario funcionario = new Funcionario();
            funcionario.cadastrar();
            funcionario.definirSalario();
            funcionario.exibirSalario();
            funcionario.Bonus();
            funcionario.Descontos(22);
        }
    }
}
