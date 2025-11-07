using System;

public class LogTransacao
{
    public string Tipo { get; private set; }
    public double Valor { get; private set; }
    public DateTime DataHora { get; private set; }
    public Funcionario Autorizador { get; private set; }
    public Guid CodigoTransacao { get; private set; }

    public LogTransacao(string tipo, double valor, Funcionario autorizador)
    {
        Tipo = tipo;
        Valor = valor;
        Autorizador = autorizador;
        DataHora = DateTime.Now;
        CodigoTransacao = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"Tipo: {Tipo} | Valor: {Valor:C2} | Data/Hora: {DataHora:dd/MM/yyyy HH:mm:ss} | Funcionário: {Autorizador.Nome} | Código: {CodigoTransacao}";
    }
}