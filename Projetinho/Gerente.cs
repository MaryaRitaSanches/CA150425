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

        public void definirSetor()
        {
            setor = "Tecnologia da Informação";
        }
        public void exibirSetor()
        {
            Console.WriteLine("O seu setor é:", setor);
        }
    }
}
