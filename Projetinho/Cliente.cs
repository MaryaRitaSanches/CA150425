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

        public void cadastrar()
        {
            Console.WriteLine("O seu Código de Identificação é: {0}", id++);
        }
        public void exibirCliente()
        {
            
        }
    }
}
