using Exercicio1;

List<IVeiculo> veiculos = new List<IVeiculo>
{
    new Avião("Gol"),
    new Avião("Latan"),
    new Bicicleta("Bicicleta do JigSaw"),
    new Carro("Celta")
};
Console.WriteLine("Acelerando todos os veículos");

foreach (var veiculo in veiculos)
{
    Console.WriteLine(veiculo.Mover());
}
    
