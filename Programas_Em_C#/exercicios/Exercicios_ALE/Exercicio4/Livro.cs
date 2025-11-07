using System;

public class Livro
{
    public Guid CodigoUnico { get; private set; }
    public string ISBN { get; private set; } 
    public string Nome { get; private set; }
    public string Editora { get; private set; }
    public string Autores { get; private set; }
    public string Genero { get; private set; }
    public string Capa { get; private set; } 
    public int Edicao { get; private set; }
    public int TotalPaginas { get; private set; }
    public string Idioma { get; private set; }
    public string Formato { get; private set; } 

    public Livro(string isbn, string nome, string editora, string autores, string genero, string capa, int edicao, int paginas, string idioma, string formato)
    {
        ISBN = isbn;
        Nome = nome;
        Editora = editora;
        Autores = autores;
        Genero = genero;
        Capa = capa;
        Edicao = edicao;
        TotalPaginas = paginas;
        Idioma = idioma;
        Formato = formato;

        CodigoUnico = Guid.NewGuid();
    }
    public override string ToString()
    {
        return $"{Nome} (Ed. {Edicao}), ISBN: {ISBN} | Formato: {Formato} | Cód. Único: {CodigoUnico}";
    }
}