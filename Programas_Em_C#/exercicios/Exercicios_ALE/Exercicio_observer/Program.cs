using Exercicio_observer;
var central = new PontuacaoCentral();
var placar = new ExibirPlacar();
var som = new SomEfeito();
var recompensa = new SistemaDeRecompensa();

central.AdicionarObservador(placar);
central.AdicionarObservador(som);
central.AdicionarObservador(recompensa);

Console.WriteLine("Jogo Iniciado");
central.AdicionarPontos(10);

Console.WriteLine("\nMais Ações");
central.RemoverObservador(som);

central.AdicionarPontos(35); 

Console.WriteLine("\nÚltima Ação (Desbloqueio)");
central.AdicionarPontos(5);
