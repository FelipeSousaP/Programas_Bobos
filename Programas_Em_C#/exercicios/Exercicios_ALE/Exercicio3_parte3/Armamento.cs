namespace Exercicio3_parte3
{
    public abstract class Armamento
    {
        public string Nome { get; private set; }
        protected int MuniçãoAtual { get; set; }
        protected int MuniçãoMaxima { get; private set; }
        protected string TeclaRecarga { get; private set; }

        public Armamento(string nome, int municaoInicial, string teclaRecarga)
        {
            Nome = nome;
            MuniçãoAtual = municaoInicial;
            MuniçãoMaxima = municaoInicial;
            TeclaRecarga = teclaRecarga;
        }
        public bool TentarAtirar()
        {
            if (MuniçãoAtual > 0)
            {
                MuniçãoAtual--;
                Console.WriteLine($"Disparo efetuado: {Nome} ({MuniçãoAtual} restantes).");
                return true;
            }
            else
            {
                Console.WriteLine($"MUNIÇÃO VAZIA! ({Nome}). Use a tecla '{TeclaRecarga}' para recarregar.");
                return false;
            }
        }

        public void Recarregar()
        {
            MuniçãoAtual = MuniçãoMaxima;
            Console.WriteLine($"RECARGA COMPLETA! {Nome} ({MuniçãoAtual} unidades).");
        }

        public int GetMunição()
        {
            return MuniçãoAtual;
        }
    }
}
