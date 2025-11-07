namespace Exercicio1_parte2
{
    public class Sala
    {
        public int Numero { get; set; }
        public int CapacidadeMaxima { get;set; }
        public int IngressosVendidos { get; set; }
        public string FilmeEmExibicao { get; set; }

        public Sala(int numero, int capacidade, string filme)
        {
            Numero = numero;
            CapacidadeMaxima = capacidade;
            FilmeEmExibicao = filme;
            IngressosVendidos = 0;
        }
        public int VagasDisponiveis
        {
            get { return CapacidadeMaxima - IngressosVendidos; }
        }
        public bool TentarVenderIngresso()
        {
            if (VagasDisponiveis > 0)
            {
                IngressosVendidos++;
                return true;
            }
            return false;
        }
    }
}
