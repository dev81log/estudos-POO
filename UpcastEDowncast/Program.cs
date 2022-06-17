internal class Program
{
    private static void Main(string[] args)
    {
        var pessoa = new Pessoa();
        // downcast
        pessoa = new PessoaFisica();
        pessoa = new PessoaJuridica();

        // upcast
        var pessoaFisica = new PessoaFisica();
        var pessoaJuridica = new PessoaJuridica();
        pessoaFisica = (PessoaFisica)pessoa;


    }
}

public class Pessoa
{
    public string Nome { get; set; }
}

public class PessoaFisica : Pessoa
{
    public int CPF { get; set; }

}

public class PessoaJuridica : Pessoa
{
    public int CNPJ { get; set; }
}

