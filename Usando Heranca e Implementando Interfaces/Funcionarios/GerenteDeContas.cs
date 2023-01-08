using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf,4000)
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
        public string Senha { get; set; }

        public bool autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
} 
