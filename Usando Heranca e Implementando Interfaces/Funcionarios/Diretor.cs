using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()// sobrescrita/override do método getBon.. herdado da classe Funcionario
        {
            return this.Salario + base.getBonificacao();// base permite acessar atributos e métodos da superclasse (da classe herdada)
        }  

        public Diretor(string cpf) : base(cpf) // base permite acessar implementações da superclasse
        {

        }
    }
}
