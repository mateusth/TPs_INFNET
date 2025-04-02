using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase) : base(nome, cargo, salarioBase*1.2)
        {
        }
    }
}
