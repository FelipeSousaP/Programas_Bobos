using Exercicio2;

public abstract class FormaGeometrica : IFormas
{
    public abstract void CriarForma();

    public abstract double CalculaArea();

    protected void MostrarCriacao(string nomeForma, string detalhes)
    {
        Console.WriteLine($"Forma criada com sucesso: {nomeForma}. {detalhes}");
    }
}
