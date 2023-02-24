namespace PaymentDelegates;
class Program
{
    //sempre que vai delegar uma função
    //Elas tem que ter a mesma assinatura
    static void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pago valor de {valor}");
    }

    static void Main(string[] args)
    {
        //ele espera uma função não um valor
        var pagar = new Pagamento.Pagar(RealizarPagamento);
        pagar(25);
    }
}

//sempre que vai delegar uma função
//Elas tem que ter a mesma assinatura
public class Pagamento
{
    public delegate void Pagar(double valor);
}