
namespace Exercicio1
{
    public class Avião : Veiculo
    {
        public Avião(string nome) : base(nome) { }

        public override string Mover()
        {
            return $"{Nome} está decolando pro ceú, rumo a nova zelândia.";
        }
    }
}
