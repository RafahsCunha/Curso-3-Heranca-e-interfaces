using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.SistemaInterno;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override bool autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
} 
