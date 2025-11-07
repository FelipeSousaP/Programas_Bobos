public class ContaBancaria
{
    public string NumeroConta { get; private set; }
    public string Titular { get; private set; }
    public double Saldo { get; private set; }
    public List<LogTransacao> Logs { get; private set; }

    public ContaBancaria(string numeroConta, string titular)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0.0;
        Logs = new List<LogTransacao>();
    }

    public string Depositar(double valor, Funcionario funcionario)
    {
        if (valor <= 0)
        {
            return "Erro: O valor do depósito deve ser positivo.";
        }
        Saldo += valor;
        var log = new LogTransacao("DEPOSITO", valor, funcionario);
        Logs.Add(log);

        return $"Depósito de {valor:C2} realizado com sucesso. Novo saldo: {Saldo:C2}";
    }

    public string Sacar(double valor, Funcionario funcionario)
    {
        if (valor <= 0)
        {
            return "Erro: O valor do saque deve ser positivo.";
        }

        if (Saldo - valor < 0)
        {
            return $"Erro: Saldo insuficiente. Saldo atual: {Saldo:C2}. Tentativa de saque: {valor:C2}";
        }
        Saldo -= valor;
        var log = new LogTransacao("SAQUE", valor, funcionario);
        Logs.Add(log);

        return $"Saque de {valor:C2} autorizado com sucesso. Novo saldo: {Saldo:C2}";
    }

    public double ConsultarSaldo()
    {
        return Saldo;
    }
}
