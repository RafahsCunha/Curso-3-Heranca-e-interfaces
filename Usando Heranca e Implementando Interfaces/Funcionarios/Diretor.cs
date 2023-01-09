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
            return this.Salario * 0.50;// base permite acessar atributos e métodos da superclasse (da classe herdada)
        }  

        public Diretor(string cpf) : base(cpf,5000) // base permite acessar implementações da superclasse
        {

        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.15; 
        }
    }
}
