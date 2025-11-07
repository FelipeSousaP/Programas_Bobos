public class Eneagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; }
    public override void CriarForma()
    {
        Lado = 9;
        DistanciDocentros = 6;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }
    public override double CalculaArea()
    {
        double perimetro = 9 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }
}
