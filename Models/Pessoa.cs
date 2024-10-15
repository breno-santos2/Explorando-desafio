namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    //Construtor padrão
    public Pessoa() { }

    // Construtor que recebe apenas o nome
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    // Construtor que recebe nome e sobrenome
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    // Propriedade para armazenar o nome
    public string Nome { get; set; }

    // Propriedade para armazenar o sobrenome
    public string Sobrenome { get; set; }

    // Propriedade que retorna o nome completo em letras maiúsculas
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}