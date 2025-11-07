public class Quadrilatero : FormaGeometrica
{
    private double Lado { get; set; }
    public override void CriarForma()
    {
        Lado = 8.0;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}");
    }
    public override double CalculaArea()
    {
        return Lado * Lado;
    }
}
