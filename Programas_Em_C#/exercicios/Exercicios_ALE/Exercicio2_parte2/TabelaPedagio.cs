namespace Exercicio2_parte2
{
    public static class TabelaPedagio
    {
        private static readonly Dictionary<TipoVeiculo, double> Precos = new Dictionary<TipoVeiculo, double>
        {
            { TipoVeiculo.CarroPequeno, 5.00 },
            { TipoVeiculo.CarroMedio, 10.00 },
            { TipoVeiculo.CarroGrande, 15.00 },
            { TipoVeiculo.VanCaminhaoOnibus, 20.00 }
        };
        public static double ObterPreco(TipoVeiculo tipo)
        {
            if (Precos.ContainsKey(tipo))
            {
                return Precos[tipo];
            }
            return 0.0;
        }
    }
}
