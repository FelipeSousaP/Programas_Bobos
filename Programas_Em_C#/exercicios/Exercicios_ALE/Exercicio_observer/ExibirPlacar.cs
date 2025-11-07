namespace Exercicio_observer
{
    public class ExibirPlacar : IObserver
    {
        public void Atualizar(int novaPontuacao)
        {
            Console.WriteLine($"[Placar] Pontuação atualizada: {novaPontuacao}");
        }
    }
}
