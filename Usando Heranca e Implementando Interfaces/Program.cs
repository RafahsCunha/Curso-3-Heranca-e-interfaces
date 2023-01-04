

using Usando_Heranca_e_Implementando_Interfaces.Desafios.DesafioAula_01;
using Usando_Heranca_e_Implementando_Interfaces.Funcionarios;
using Usando_Heranca_e_Implementando_Interfaces.Utilitario;

// #region #endregion oculta uma cadeia de códigos
#region 
//Funcionario rafael = new Funcionario("123456789",2000);
//rafael.Nome = "Rafael Henrique";

//Console.WriteLine("Funcionario: " + rafael.Nome);
//Console.WriteLine("Salario: R$ " + rafael.Salario);
//Console.WriteLine("Bonificacao: R$ " + rafael.getBonificacao());



//Diretor jennyfer = new Diretor("987654321");
//jennyfer.Nome = "Jennyfer Ribeiro";

//Console.WriteLine("Funcionario: " + jennyfer.Nome);
//Console.WriteLine("Salario: R$ " + jennyfer.Salario);
//Console.WriteLine("Bonificacao: R$ " + jennyfer.getBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(rafael); // Exemplo de Polimorfismo
//gerenciador.Registrar(jennyfer); // Exemplo de Polimorfismo

//Console.WriteLine("\nTotal de Bonificação: R$ " + gerenciador.TotalDeBonificacao);

//Console.WriteLine("\nTotal de Funcionários: " + Funcionario.TotalDeFuncionarios); //Contabiliza funcionários do tipo Diretor por causa do conceito de herança

//rafael.aumentarSalario();
//jennyfer.aumentarSalario();

//Console.WriteLine("\nNovo Salario do Rafael. " + rafael.Salario);
//Console.WriteLine("\nNovo Salario do Jennyfer. " + jennyfer.Salario);
#endregion 

calcularBonificacao();
void calcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Auxiliar joao = new Auxiliar("123456789-10");
    joao.Nome = "Joao";

    Designer emanuelle = new Designer("654987321-78");
    emanuelle.Nome = "Emanuelle";

    Diretor rafael = new Diretor("987654321-01");
    rafael.Nome = "Rafael";

    GerenteDeContas jennyfer = new GerenteDeContas("13279846-89");
    jennyfer.Nome = "Jennyfer";

    gerenciador.Registrar(joao);
    gerenciador.Registrar(emanuelle);
    gerenciador.Registrar(rafael);
    gerenciador.Registrar(jennyfer);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);

}