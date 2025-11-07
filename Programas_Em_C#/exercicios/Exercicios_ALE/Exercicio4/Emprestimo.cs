using System;

public class Emprestimo
{
    public string MatriculaAluno { get; private set; }
    public Livro LivroEmprestado { get; private set; } 
    public DateTime DataRetirada { get; private set; }
    public DateTime DataDevolucaoPrevista { get; private set; }
    public string Status { get; private set; } 
    public DateTime? DataDevolucaoReal { get; private set; }

    public Emprestimo(string matriculaAluno, Livro livro)
    {
        MatriculaAluno = matriculaAluno;
        LivroEmprestado = livro;
        DataRetirada = DateTime.Now;
        DataDevolucaoPrevista = DateTime.Now.AddDays(14); 
        Status = "PENDENTE";
        DataDevolucaoReal = null;
    }
    public void RegistrarDevolucao()
    {
        if (Status == "PENDENTE")
        {
            Status = "DEVOLVIDO";
            DataDevolucaoReal = DateTime.Now;
        }
    }
    public override string ToString()
    {
        string devolucao = (Status == "DEVOLVIDO")
            ? $"Devolvido em {DataDevolucaoReal:dd/MM/yyyy HH:mm}"
            : $"Previsto para {DataDevolucaoPrevista:dd/MM/yyyy}";

        return $"Aluno: {MatriculaAluno} | Livro: {LivroEmprestado.Nome} | Status: {Status} | {devolucao}";
    }
}
