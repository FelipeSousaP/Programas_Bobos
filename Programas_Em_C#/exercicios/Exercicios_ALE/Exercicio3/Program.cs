var gerente = new Funcionario(101, "Ale professor");
var caixa = new Funcionario(102, "Jp");

var conta = new ContaBancaria("12345-6", "Delipe Oliveira");

Console.WriteLine($"Conta Criada: {conta.Titular} ({conta.NumeroConta})");
Console.WriteLine($"Saldo Inicial: {conta.ConsultarSaldo():C2}\n");

Console.WriteLine(conta.Depositar(500.00, caixa));

Console.WriteLine(conta.Sacar(150.00, gerente));

Console.WriteLine(conta.Sacar(400.00, caixa));

Console.WriteLine($"\nSaldo Final: {conta.ConsultarSaldo():C2}\n");

Console.WriteLine("Histórico de Transações");
foreach (var log in conta.Logs)
{
    Console.WriteLine(log.ToString());
}