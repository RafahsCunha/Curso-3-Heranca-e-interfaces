using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Diretor : Funcionario
    {
        public double getBonificacao()
        {
            return this.Salario;
        }
    }
}
