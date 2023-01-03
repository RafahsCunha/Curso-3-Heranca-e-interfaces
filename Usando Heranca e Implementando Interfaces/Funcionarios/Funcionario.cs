using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }// Propriedade statica da classe, permite que o construtor seja acessado sem ter que criar um objeto

        public Funcionario()
        {
            TotalDeFuncionarios++;
        }

        public virtual double getBonificacao() // Será reescrito/override na classe Diretor
        {
            return this.Salario * 0.10;
        }
    }
}
