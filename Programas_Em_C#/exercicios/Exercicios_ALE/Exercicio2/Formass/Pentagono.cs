public class Pentagono : FormaGeometrica
{
    private double Lado { get; set; }
    private double DistanciDocentros { get; set; } 

    public override void CriarForma()
    {
        Lado = 5.0;
        DistanciDocentros = 3.44;
        MostrarCriacao(this.GetType().Name, $"Lado: {Lado}, Apótema: {DistanciDocentros}");
    }

    public override double CalculaArea()
    {
        double perimetro = 5 * Lado;
        return (perimetro * DistanciDocentros) / 2;
    }
}
