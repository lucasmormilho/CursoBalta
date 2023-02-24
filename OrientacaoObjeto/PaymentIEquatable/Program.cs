namespace PaymentIEquatable;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var pessoaA = new Pessoa(1, "Lucas Star");
        var pessoaB = new Pessoa(1, "Lucas Star");

        //igual não funciona pois são objetos de tipo de referencia não valor
        System.Console.WriteLine(pessoaA == pessoaB);
        //usar o equals com Iequataable
        System.Console.WriteLine(pessoaA.Equals(pessoaB));

    }
}

//usar iequatable para comparar dois objetos
public class Pessoa : IEquatable<Pessoa>
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public bool Equals(Pessoa? pessoa)
    {
        return Id == pessoa.Id;
    }
}
