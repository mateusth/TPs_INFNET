using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    public class Funcionario
    {
        public string nome;
        public string cargo;
        public double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public void exibirSalario()
        {
            Console.WriteLine($"{nome} tem salario de R${salarioBase}");

        }
    }
}
