namespace Exercicio_observer
{
    public class SomEfeito : IObserver
    {
        public void Atualizar(int novaPontuacao)
        {
            Console.WriteLine($"[Efeito Sonoro] Tocando som de pontuação! (Valor: {novaPontuacao})");
        }
    }
}
