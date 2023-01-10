using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.SistemaInterno;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public override double getBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
