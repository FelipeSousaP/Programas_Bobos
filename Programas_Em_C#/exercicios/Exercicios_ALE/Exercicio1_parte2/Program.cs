using Exercicio1_parte2;
double precoIngresso = 25.00;
var sistema = new SistemaVendas(precoIngresso);

Console.WriteLine("--- LOGIN DO OPERADOR ---");
Console.Write("Digite o nome do operador: ");
string nomeOperador = Console.ReadLine();
Console.Write("Digite o ID do operador: ");
string idOperador = Console.ReadLine();
sistema.Login(nomeOperador, idOperador);

while (true)
{
    Console.WriteLine("\n--- NOVA TRANSAÇÃO ---");
    sistema.ExibirStatusSalas();

    Console.WriteLine("\nO que deseja fazer?");
    Console.WriteLine("1 - Vender Ingresso");
    Console.WriteLine("2 - Fechar Caixa");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine();

    if (opcao == "2")
    {
        sistema.FecharCaixa();
        break;
    }
    else if (opcao == "1")
    {
        Console.Write("Para qual sala (1, 2 ou 3) será vendido o ingresso? ");
        if (int.TryParse(Console.ReadLine(), out int numSala))
        {
            sistema.RealizarVenda(numSala);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}