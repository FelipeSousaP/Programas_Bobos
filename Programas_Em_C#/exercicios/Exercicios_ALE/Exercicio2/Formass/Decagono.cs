public class Decagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; }
    public override void CriarForma()
    {
        Lado = 10;
        DistanciDocentros = 1.2;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }
    public override double CalculaArea()
    {
        double perimetro = 10 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }

}
