namespace PaymentUpDownCasting;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    }
}


public class Pessoa
{
    public string Nome { get; set; }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
}

public class PessoaJuridica : Pessoa
{
    public string CNPJ { get; set; }
}