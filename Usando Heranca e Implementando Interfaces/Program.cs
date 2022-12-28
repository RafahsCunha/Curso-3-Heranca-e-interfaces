

using Usando_Heranca_e_Implementando_Interfaces.Desafios.DesafioAula_01;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;
using Usando_Heranca_e_Implementando_Interfaces.Utilitario;

Funcionario rafael = new Funcionario();
rafael.Nome = "Rafael Henrique";
rafael.Cpf = "123456789";
rafael.Salario = 2000;

Console.WriteLine("Funcionario: " + rafael.Nome);
Console.WriteLine("Salario: R$ " + rafael.Salario);
Console.WriteLine("Bonificacao: R$ " + rafael.getBonificacao());



Diretor jennyfer = new Diretor();
jennyfer.Nome = "Jennyfer Ribeiro";
jennyfer.Cpf = "987654321";
jennyfer.Salario = 5000;

Console.WriteLine("Funcionario: " + jennyfer.Nome);
Console.WriteLine("Salario: R$ " + jennyfer.Salario);
Console.WriteLine("Bonificacao: R$ " + jennyfer.getBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(rafael); // Exemplo de Polimorfismo
gerenciador.Registrar(jennyfer); // Exemplo de Polimorfismo

Console.WriteLine("Total de Bonificação: R$ " + gerenciador.TotalDeBonificacao);


Operacoes operacoes = new Operacoes();
operacoes.soma(1, 2);