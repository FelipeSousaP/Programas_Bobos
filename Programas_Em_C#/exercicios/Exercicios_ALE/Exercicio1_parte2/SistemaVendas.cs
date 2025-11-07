namespace Exercicio1_parte2
{
    public class SistemaVendas
    {
        private List<Sala> salas;
        private double precoIngresso;
        private double receitaTotal;
        private int ingressosTotalVendidos;
        private Operador operadorLogado;

        public SistemaVendas(double precoBaseIngresso)
        {
            precoIngresso = precoBaseIngresso;
            receitaTotal = 0;
            ingressosTotalVendidos = 0;

            salas = new List<Sala>
            {
                new Sala(1, 30, "A Lenda de Kora"),
                new Sala(2, 35, "O Mistério da Ilha"),
                new Sala(3, 55, "A Máquina do Tempo")
            };
        }

        public void Login(string nome, string id)
        {
            operadorLogado = new Operador(nome, id);
            Console.WriteLine($"Operador {nome} (ID: {id}) logado com sucesso.");
        }

        public void RealizarVenda(int numeroSala)
        {
            if (operadorLogado == null)
            {
                Console.WriteLine("ERRO: Nenhum operador logado. Faça o login primeiro.");
                return;
            }

            var salaSelecionada = salas.FirstOrDefault(s => s.Numero == numeroSala);

            if (salaSelecionada == null)
            {
                Console.WriteLine($"ERRO: Sala {numeroSala} não encontrada.");
                return;
            }

            if (salaSelecionada.TentarVenderIngresso())
            {
                ingressosTotalVendidos++;
                receitaTotal += precoIngresso;
                Console.WriteLine($"INGRESSO VENDIDO! Filme: {salaSelecionada.FilmeEmExibicao} (Sala {salaSelecionada.Numero}).");
                Console.WriteLine($"Vagas restantes na sala {salaSelecionada.Numero}: {salaSelecionada.VagasDisponiveis}");
            }
            else
            {
                Console.WriteLine($"ATENÇÃO: Venda não realizada. Sala {salaSelecionada.Numero} ({salaSelecionada.FilmeEmExibicao}) está lotada.");
            }
        }

        public void ExibirStatusSalas()
        {
            Console.WriteLine("\n--- STATUS DAS SALAS ---");
            foreach (var sala in salas)
            {
                Console.WriteLine($"Sala {sala.Numero} ({sala.FilmeEmExibicao}): Capacidade: {sala.CapacidadeMaxima} | Vendidos: {sala.IngressosVendidos} | Disponível: {sala.VagasDisponiveis}");
            }
        }

        public void FecharCaixa()
        {
            if (operadorLogado == null)
            {
                Console.WriteLine("ERRO: Não é possível fechar o caixa sem um operador logado.");
                return;
            }
            Console.WriteLine("\n==============================================");
            Console.WriteLine("          FECHAMENTO DE CAIXA DO DIA          ");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Operador Responsável: {operadorLogado.Nome} (ID: {operadorLogado.Id})");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Total de Ingressos Vendidos: {ingressosTotalVendidos}");
            Console.WriteLine($"Total em Dinheiro no Caixa: {receitaTotal:C2}");
            Console.WriteLine("==============================================");
        }
    }
}
