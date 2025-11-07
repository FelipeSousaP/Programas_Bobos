var biblioteca = new Biblioteca();
var livro1 = new Livro("978-8576082675", "Engenharia de Software", "Pearson", "Pressman", "Técnico", "Brochura", 8, 700, "Português", "Impresso");
var livro2 = new Livro("978-0137082403", "Design Patterns", "Addison-Wesley", "Gamma et al.", "Técnico", "Dura", 1, 395, "Inglês", "Impresso");
biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);

Console.WriteLine("\nSimulação de Empréstimos\n");
var emprestimo1 = biblioteca.EmprestarLivro("M12345", livro1.CodigoUnico);
biblioteca.EmprestarLivro("M67890", livro1.CodigoUnico);
biblioteca.EmprestarLivro("M67890", livro2.CodigoUnico);
Console.WriteLine("\nHistórico de Empréstimos\n");

foreach (var emp in biblioteca.HistoricoEmprestimos)
{
    Console.WriteLine(emp.ToString());
}

if (emprestimo1 != null)
{
    emprestimo1.RegistrarDevolucao();
    Console.WriteLine($"\nDevolução do livro '{emprestimo1.LivroEmprestado.Nome}' registrada com sucesso.");
}
