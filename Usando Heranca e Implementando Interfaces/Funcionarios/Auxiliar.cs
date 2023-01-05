using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
          
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.20;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.10; 
        }

    }
}
