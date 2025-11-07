using Exercicio3_parte3;

var defesa = new SistemaDefesa();
Console.WriteLine("SISTEMA DE DEFESA ATIVADO: Sobrevivência contra Zumbis!");

while (true)
{
    defesa.ExibirStatus();
    Console.Write("\nComando (A, L, B, T | Recarregar 1 ou 2 | Sair Q): ");
    var key = Console.ReadKey(true).KeyChar;

    if (char.ToUpper(key) == 'Q')
    {
        break;
    }

    defesa.ProcessarComando(key);
}

Console.WriteLine("\nFIM DA SIMULAÇÃO.");
    