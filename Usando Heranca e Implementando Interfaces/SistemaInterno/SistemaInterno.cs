using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;

namespace Usando_Heranca_e_Implementando_Interfaces.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuario Logado. Bem vindo ao sistema!");
                return true;
            }
            else
            {
                
                Console.WriteLine("Senha incorreta!");
                return false;
            }

        }
    }
}
