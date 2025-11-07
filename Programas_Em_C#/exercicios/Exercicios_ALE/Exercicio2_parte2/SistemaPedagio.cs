namespace Exercicio2_parte2
{
    public class SistemaPedagio
    {
        private double totalArrecadado;
        public SistemaPedagio()
        {
            totalArrecadado = 0.0;
        }

        public double RealizarCobranca(TipoVeiculo tipo)
        {
            double valorCobranca = TabelaPedagio.ObterPreco(tipo);
            if (valorCobranca > 0)
            {
                totalArrecadado += valorCobranca;
                Console.WriteLine($"Cobrança realizada para {tipo}. Valor: {valorCobranca:C2}.");
                return valorCobranca;
            }
            else
            {
                Console.WriteLine($"ERRO: Tipo de veículo {tipo} não tem preço definido.");
                return 0.0;
            }
        }
        public void FecharDia()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("          FECHAMENTO DE DIA DO PEDÁGIO   ");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Valor Total Arrecadado: {totalArrecadado:C2}");
            Console.WriteLine("=========================================");
        }
    }
}
