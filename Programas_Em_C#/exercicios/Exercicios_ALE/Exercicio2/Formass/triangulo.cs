public class Triangulo : FormaGeometrica
{
    private double Base { get; set; }
    private double Altura { get; set; }
    public override void CriarForma()
    {
        Base = 10.0;
        Altura = 5.0;
        MostrarCriacao(this.GetType().Name, $"Base: {Base}, Altura: {Altura}");
    }
    public override double CalculaArea()
    {
        return (Base * Altura) / 2;
    }
}