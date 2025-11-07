
namespace Exercicio1
{
    public class Bicicleta : Veiculo
    {
        public Bicicleta(string nome) : base(nome) { }

        public override string Mover()
        {
            return $"{Nome} está pedalando no parque";
        }
    }
}
