internal class Program
{
    static void Main(string[] args)
    {
        var pessoaA = new Pessoa(1, "Dev 81 Log");
        var pessoaB = new Pessoa(1, "Dev 81 Log");

        Console.WriteLine(pessoaA.Equals(pessoaB)); // Equals irá comparar se é igual vindo IEquatable
    }
}


class Pessoa : IEquatable<Pessoa> // IEquatable<Pessoa> vindo de generics
{
    public Pessoa(int id, string nome) // construtor
    {
        ID = id;
        Nome = nome;
    }

    public int ID { get; set; }
    public string Nome { get; set; }

    public bool Equals(Pessoa pessoa) // props com Equals
    {
        return ID == pessoa.ID; // retorna a comparação 
    }
}

