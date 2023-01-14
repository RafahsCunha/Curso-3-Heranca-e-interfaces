using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.SistemaInterno;

namespace Usando_Heranca_e_Implementando_Interfaces.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get ; set;}
        public string Login { get; set;}

        public bool autenticar(string senha, string login)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}
