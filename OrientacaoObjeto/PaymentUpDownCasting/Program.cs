namespace PaymentUpDownCasting;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //era pessoa
        var pessoa = new Pessoa();
        //virou fisica
        //UPCASTING
        pessoa = new PessoaFisica();
        //virou juridica
        //UPCASTING
        pessoa = new PessoaJuridica();

        var pessoa2 = new Pessoa();
        var pessoaFisica = new PessoaFisica();
        var pessoaJuridica = new PessoaJuridica();

        //DOWNCASTING
        pessoaFisica = (PessoaFisica)pessoa2;

    }
}

//classe base, pai, raiz
public class Pessoa
{
    public string Nome { get; set; }
}

//classe filha
public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
}

//classe filha
public class PessoaJuridica : Pessoa
{
    public string CNPJ { get; set; }
}