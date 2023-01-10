using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }// acesso permitido somente pelo método construtor
        public double Salario { get; protected set; } // protected, visivel na classe mãe e nas classe filha

        public static int TotalDeFuncionarios { get; private set; }


        public abstract double getBonificacao(); // Implementação obrigatório nas classes que herdam de Funcionario
        

        public Funcionario(string cpf,double salario) // Não é um construtor abstract, logo não possui implementação obrigatória
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }
        public abstract void aumentarSalario();// Implementação obrigatório nas classes que herdam de Funcionario

    }
}
