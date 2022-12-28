using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;

namespace Usando_Heranca_e_Implementando_Interfaces.Utilitario

{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }//set só pode ser manipulado dentro da classe

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor diretor) // Sobrecarga do método Registrar
        {
            this.TotalDeBonificacao += diretor.getBonificacao();
        }
    }
}
