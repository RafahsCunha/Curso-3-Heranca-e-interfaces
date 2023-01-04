using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf,3000)
        {

        }

        public override double getBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
