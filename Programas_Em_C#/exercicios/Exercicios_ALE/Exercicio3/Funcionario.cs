public class Funcionario
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Funcionario(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}";
    }
}
