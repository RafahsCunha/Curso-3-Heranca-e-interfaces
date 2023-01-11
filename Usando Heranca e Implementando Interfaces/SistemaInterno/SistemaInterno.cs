using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;
using Usando_Heranca_e_Implementando_Interfaces.Parceria;

namespace Usando_Heranca_e_Implementando_Interfaces.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(Autenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.autenticar(senha,login);
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

        public bool logar(ParceiroComercial parceiro, string senha, string login)
        {
            bool usuarioAutenticado = parceiro.autenticar(senha, login);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Parceiro logado. Bem vindo ao sistema!");
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
