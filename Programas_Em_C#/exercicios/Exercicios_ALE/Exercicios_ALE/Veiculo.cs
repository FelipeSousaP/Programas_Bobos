namespace Exercicio1
{
    public abstract class Veiculo : IVeiculo
    {
        public string Nome { get; private set; }
        public Veiculo(string nome)
        {
            Nome = nome;
        }
        public abstract string Mover();
    }
}
