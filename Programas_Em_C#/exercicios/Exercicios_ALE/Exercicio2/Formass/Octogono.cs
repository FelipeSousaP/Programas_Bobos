public class Octagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; }

    public override void CriarForma()
    {
        Lado = 8.0;
        DistanciDocentros = 4.5;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }

    public override double CalculaArea()
    {
        double perimetro = 8 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }
}
