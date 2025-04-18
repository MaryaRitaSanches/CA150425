using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Cliente : Pessoa
    {
        protected int id = 0;

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o seu id:");
            this.id = int.Parse(Console.ReadLine()); 
        }
        public void exibirCliente()
        {
            Console.WriteLine("O seu Código de identificação é:{0}", this.id);
        }
    }
}
