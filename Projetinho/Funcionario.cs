using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Funcionario : Pessoa
    {
        private double salario;
        protected int registro;
        Pessoa[] dependentes = new Pessoa[5];

        public void definirSalario()
        {
            Console.WriteLine("Digite o seu registro:");
            this.registro = int.Parse(Console.ReadLine());
            if (registro <= 1729)
            {
                Console.WriteLine("Digite o seu salario é de R$ 1.500,00", this.salario);
            }
            else if (registro <= 2637328)
            {
                Console.WriteLine("Digite o seu salario é de R$ 2.500,00", this.salario);
            }
            else 
            {
                Console.WriteLine("Digite o seu salario é de R$ 4.500,00",this.salario);
            }
        }
        public void exibirSalario()
        {
            Console.WriteLine("Digite o seu registro:");
            this.registro = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu salario é de R$ {0}", this.salario);
        }
        public double Descontos(double valorCompra)
        {
            Console.WriteLine("Digite o valor da compra:");
            valorCompra = double.Parse(Console.ReadLine());
            return valorCompra * 0.1;
        }
        public double Bonus()
        {
            Console.WriteLine("Digite o seu salario:");
            this.salario = double.Parse(Console.ReadLine());
            return salario * 0.5;
        }
        public void consultarRegistro()
        {
             
        }
        public void adicionarDependente()
        {

        }
    }
}
