namespace Exercicio4_parte2
{
    public class ItemCompra
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public string TipoCobranca { get; private set; } 
        public ItemCompra(string nome, double preco, string tipoCobranca)
        {
            Nome = nome;
            Preco = preco;
            TipoCobranca = tipoCobranca;
        }
    }
}
