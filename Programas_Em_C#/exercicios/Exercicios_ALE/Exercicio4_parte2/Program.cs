using Exercicio4_parte2;

var sistema = new SistemaTotem();

while (true)
{
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("   MERCADINHO DO TIO JOÃO - TOTEM   ");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Deseja iniciar uma nova lista de compras?");
    Console.WriteLine("I - Iniciar");
    Console.WriteLine("E - Encerrar Programa");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine().ToUpper();

    if (opcao == "E")
    {
        Console.WriteLine("\nPrograma encerrado. Até mais!");
        break;
    }
    else if (opcao == "I")
    {
        sistema.IniciarNovaLista();
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}
