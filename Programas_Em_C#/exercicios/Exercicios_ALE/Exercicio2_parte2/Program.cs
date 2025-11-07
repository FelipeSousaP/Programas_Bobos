using Exercicio2_parte2;

var sistema = new SistemaPedagio();
Console.WriteLine("SIMULAÇÃO DE PEDÁGIO");

while (true)
{
    Console.WriteLine("\nQual veículo está passando?");
    Console.WriteLine("1: Carro Pequeno (R$ 5,00)");
    Console.WriteLine("2: Carro Médio (R$ 10,00)");
    Console.WriteLine("3: Carro Grande (R$ 15,00)");
    Console.WriteLine("4: Van, Caminhão ou Ônibus (R$ 20,00)");
    Console.WriteLine("0: Fechar Dia (Encerrar)");
    Console.Write("Opção: ");
    string entrada = Console.ReadLine();

    if (entrada == "0")
    {
        sistema.FecharDia();
        break;
    }

    TipoVeiculo? tipoSelecionado = null;

    switch (entrada)
    {
        case "1":
            tipoSelecionado = TipoVeiculo.CarroPequeno;
            break;
        case "2":
            tipoSelecionado = TipoVeiculo.CarroMedio;
            break;
        case "3":
            tipoSelecionado = TipoVeiculo.CarroGrande;
            break;
        case "4":
            tipoSelecionado = TipoVeiculo.VanCaminhaoOnibus;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            continue;
    }

    if (tipoSelecionado.HasValue)
    {
        sistema.RealizarCobranca(tipoSelecionado.Value);
    }
}