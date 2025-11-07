// Lista usando o tipo da interface para polimorfismo
using Exercicio2;

List<IFormas> formas = new List<IFormas>
{
    new Triangulo(),
    new Quadrilatero(),
    new Pentagono(),
    new Hexagono(),
    new Heptagono(),
    new Octagono(),
    new Eneagono(),
    new Decagono()
};

Console.WriteLine("Criando Formas");
foreach (var forma in formas)
{
    forma.CriarForma();
}

Console.WriteLine("\nCálculo de Área");
foreach (var forma in formas)
{
    Console.WriteLine($"{forma.GetType().Name} - Área: {forma.CalculaArea():F2}");
}
