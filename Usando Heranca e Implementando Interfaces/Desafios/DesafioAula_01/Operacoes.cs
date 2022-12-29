using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Desafios.DesafioAula_01
{
    public class Operacoes
    {
        public void soma(double valor1,double valor2)//
        {
            double resultado = valor1 + valor2;
            Console.WriteLine("Resultado Desafio: " + resultado);
        } 
        public void multiplicacao(double valor1,double valor2)
        {
            double resultado = valor1 * valor2;
            Console.WriteLine("Resultado Desafio: " + resultado);
        } 
        public void subitracao(double valor1,double valor2)
        {
            double resultado = valor1 - valor2;
            Console.WriteLine("Resultado Desafio: " + resultado);
        } 
        public void divisao(double valor1,double valor2)
        {
            double resultado = valor1 / valor2;
            Console.WriteLine("Resultado Desafio: " + resultado);
        } 
    }
}
