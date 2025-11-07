public class Hexagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; }

    public override void CriarForma()
    {
        Lado = 6;
        DistanciDocentros = 44;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }

    public override double CalculaArea()
    {
        double perimetro = 6 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }
}
