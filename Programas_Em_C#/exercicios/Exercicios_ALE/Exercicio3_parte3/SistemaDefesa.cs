using Exercicio3_parte3.ataques;

namespace Exercicio3_parte3
{
    public class SistemaDefesa
    {
        private Dictionary<char, Armamento> armasComuns;
        private AtaqueEspecial ataqueEspecial;

        private const char TECLA_RECARGA_20 = '1';
        private const char TECLA_RECARGA_10 = '2';
        private const char TECLA_ESPECIAL = 'T';

        public SistemaDefesa()
        {
            armasComuns = new Dictionary<char, Armamento>();
            armasComuns.Add('A', new AtaquePorta20("Lápis e Canetas (Porta 1)", TECLA_RECARGA_20.ToString()));
            armasComuns.Add('L', new AtaquePorta20("Teclados e Mouses (Porta 2)", TECLA_RECARGA_20.ToString()));
            armasComuns.Add('B', new AtaqueJanela10("Cadeiras (Janela)", TECLA_RECARGA_10.ToString()));

            ataqueEspecial = new AtaqueEspecial();
        }

        public void ExibirStatus()
        {
            Console.WriteLine("\n--- STATUS ATUAL ---");
            Console.WriteLine($"[Porta 1 - Tecla A] Lápis/Canetas: {armasComuns['A'].GetMunição()} / 20");
            Console.WriteLine($"[Porta 2 - Tecla L] Teclados/Mouses: {armasComuns['L'].GetMunição()} / 20");
            Console.WriteLine($"[Janela - Tecla B] Cadeiras: {armasComuns['B'].GetMunição()} / 10");
            Console.WriteLine($"[Especial - Tecla T] Alunos: {ataqueEspecial.GetMunição()} / 40");
            Console.WriteLine("----------------------");
        }

        public void ProcessarComando(char comando)
        {
            comando = char.ToUpper(comando);

            if (comando == TECLA_ESPECIAL)
            {
                ataqueEspecial.TentarAtirar();
                return;
            }

            if (armasComuns.ContainsKey(comando))
            {
                armasComuns[comando].TentarAtirar();
            }
            else if (comando == TECLA_RECARGA_20)
            {
                RecarregarTodas20();
            }
            else if (comando == TECLA_RECARGA_10)
            {
                RecarregarTodas10();
            }
            else
            {
                Console.WriteLine($"Comando '{comando}' inválido. Tente A, L, B, T, 1 ou 2.");
            }
        }
        private void RecarregarTodas20()
        {
            armasComuns['A'].Recarregar();
            armasComuns['L'].Recarregar();
        }
        private void RecarregarTodas10()
        {
            armasComuns['B'].Recarregar();
        }
    }
}
