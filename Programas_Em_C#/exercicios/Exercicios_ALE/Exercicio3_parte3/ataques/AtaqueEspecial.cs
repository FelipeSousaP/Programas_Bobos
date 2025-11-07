namespace Exercicio3_parte3.ataques
{
    public class AtaqueEspecial
    {
        private int AlunosDisponiveis { get; set; }

        public AtaqueEspecial()
        {
            AlunosDisponiveis = 40; 
        }
        public bool TentarAtirar()
        {
            if (AlunosDisponiveis > 0)
            {
                AlunosDisponiveis--;
                Console.WriteLine($"ATAQUE ESPECIAL EXECUTADO! Um companheiro se sacrificou. {AlunosDisponiveis} alunos restantes.");
                return true;
            }
            else
            {
                Console.WriteLine("ATAQUE ESPECIAL VAZIO! Não há mais companheiros para o sacrifício.");
                return false;
            }
        }

        public int GetMunição()
        {
            return AlunosDisponiveis;
        }
    }
}
