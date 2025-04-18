using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Gerente : Funcionario
    {
        public string setor;

       public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o seu setor");
            this.setor = Console.ReadLine();
        }
        public void exibirSetor()
        {
            Console.WriteLine("O seu setor é:", this.setor);
        }
    }
}
