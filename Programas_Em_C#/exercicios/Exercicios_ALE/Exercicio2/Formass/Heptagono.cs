public class Heptagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; }

    public override void CriarForma()
    {
        Lado = 7;
        DistanciDocentros = 5;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }

    public override double CalculaArea()
    {
        double perimetro = 7 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }
}
