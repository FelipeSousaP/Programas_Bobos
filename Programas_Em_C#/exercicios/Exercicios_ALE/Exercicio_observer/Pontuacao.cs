namespace Exercicio_observer
{
    public class PontuacaoCentral
    {
        private List<IObserver> observadores;
        private int pontuacaoAtual;

        public int Pontuacao
        {
            get { return pontuacaoAtual; }
            private set
            {
                if (pontuacaoAtual != value)
                {
                    pontuacaoAtual = value;
                    NotificarObservadores();
                }
            }
        }

        public PontuacaoCentral()
        {
            observadores = new List<IObserver>();
            pontuacaoAtual = 0;
        }

        public void AdicionarObservador(IObserver observador)
        {
            observadores.Add(observador);
        }

        public void RemoverObservador(IObserver observador)
        {
            observadores.Remove(observador);
        }
        private void NotificarObservadores()
        {
            foreach (var observador in observadores)
            {
                observador.Atualizar(pontuacaoAtual);
            }
        }
        public void AdicionarPontos(int pontos)
        {
            if (pontos > 0)
            {
                Pontuacao += pontos;
            }
        }
        public void ZerarPontuacao()
        {
            Pontuacao = 0;
        }
    }
}
