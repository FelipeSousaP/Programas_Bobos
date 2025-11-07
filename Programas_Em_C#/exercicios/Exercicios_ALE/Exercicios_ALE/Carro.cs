
namespace Exercicio1
{
    public class Carro : Veiculo
    {
        public Carro(string nome) : base(nome) { }

        public override string Mover()
        {
            return $"{Nome} está acelerando na estrada, usando as rodas.";
        }
    }
}
