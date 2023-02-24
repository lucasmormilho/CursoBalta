namespace PaymentInterface;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class PagamentoCredito : IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {
    }
}


public class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {
    }
}

//interface é um contrato
//interface não tem implementação
//obriga o que precisa ser feito
public interface IPagamento
{
    public DateTime Vencimento { get; set; }
    //não tem implementação no metodo abaixo
    void Pagar(double valor);
}