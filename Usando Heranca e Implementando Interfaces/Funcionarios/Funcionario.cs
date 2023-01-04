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
        public string Cpf { get; private set; }// acesso permitido somente pelo método construtor
        public double Salario { get; protected set; } // protected, visivel na classe mãe e nas classe filha

        public static int TotalDeFuncionarios { get; private set; }// Propriedade statica da classe, permite que o construtor seja acessado sem ter que criar um objeto


        public virtual double getBonificacao() // Será reescrito/override na classe Diretor
        {
            return this.Salario * 0.10;
        }

        public Funcionario(string cpf,double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }
        public virtual void aumentarSalario()
        {
            this.Salario *= 1.10;
        }



    }
}
