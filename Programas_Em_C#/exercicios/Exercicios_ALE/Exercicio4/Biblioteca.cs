public class Biblioteca
{
    public List<Livro> Acervo { get; private set; }
    public List<Emprestimo> HistoricoEmprestimos { get; private set; }

    public Biblioteca()
    {
        Acervo = new List<Livro>();
        HistoricoEmprestimos = new List<Emprestimo>();
    }

    public void AdicionarLivro(Livro livro)
    {
        if (Acervo.Any(l => l.CodigoUnico == livro.CodigoUnico))
        {
            Console.WriteLine($"ERRO: Livro com Código Único {livro.CodigoUnico} já existe no acervo.");
            return;
        }
        Acervo.Add(livro);
        Console.WriteLine($"Livro '{livro.Nome}' adicionado ao acervo. Total de livros: {Acervo.Count}");
    }

    public Emprestimo EmprestarLivro(string matriculaAluno, Guid codigoUnicoLivro)
    {
        var livroParaEmprestar = Acervo.FirstOrDefault(l => l.CodigoUnico == codigoUnicoLivro);

        if (livroParaEmprestar == null)
        {
            Console.WriteLine($"ERRO: Livro com código {codigoUnicoLivro} não encontrado no acervo.");
            return null;
        }

        if (HistoricoEmprestimos.Any(e => e.LivroEmprestado.CodigoUnico == codigoUnicoLivro && e.Status == "PENDENTE"))
        {
            Console.WriteLine($"ERRO: A cópia do livro '{livroParaEmprestar.Nome}' já está emprestada.");
            return null;
        }

        var novoEmprestimo = new Emprestimo(matriculaAluno, livroParaEmprestar);
        HistoricoEmprestimos.Add(novoEmprestimo);

        Console.WriteLine($"Empréstimo realizado: '{livroParaEmprestar.Nome}' para aluno {matriculaAluno}.");
        return novoEmprestimo;
    }
}
