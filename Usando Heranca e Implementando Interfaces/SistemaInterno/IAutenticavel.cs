using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;

namespace Usando_Heranca_e_Implementando_Interfaces.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }
        public bool autenticar(string login,string senha);

    }
}
