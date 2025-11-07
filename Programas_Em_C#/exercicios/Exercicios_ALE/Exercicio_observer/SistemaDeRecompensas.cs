namespace Exercicio_observer
{
    public class SistemaDeRecompensa : IObserver
    {
        private int ultimaPontuacao;
        public SistemaDeRecompensa()
        {
            ultimaPontuacao = 0;
        }
        public void Atualizar(int novaPontuacao)
        {
            if (novaPontuacao >= 50 && ultimaPontuacao < 50)
            {
                Console.WriteLine("[Recompensa] PARABÉNS! Você alcançou 50 pontos e desbloqueou um bônus!");
            }
            ultimaPontuacao = novaPontuacao;
        }
    }
}
