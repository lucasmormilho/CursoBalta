namespace PaymentAbstract;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //ABAIXO ESTA ERRADO POIS UM PAGAMENTO SOZINHO NÃO EXISTE
        //POR ISSO A CLASSE PAGAMENTO PRECISA SER ABSTRATA
        //var pagamento = new Pagamento();
    }
}

//ATENÇÃO NÃO EXISTE UM PAGAMENTO VAGO!!!
//PAGAMENTO TEM QUE TER UM TIPO!!!
//DINHEIRO, CREDITO, BOLETO, ETC
//POR ISSO ELA É ABSTRATA
//INTERFACE FALA O QUE TEM QUE SER FEITO SEM IMPLEMENTAÇÃO
//ABSTRACT DIZ COMO FAZER POIS POSSUI IMPLEMENTAÇÃO
public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
    }
}
//herança
public class PagamentoCredito : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}
public class PagamentoBoleto : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}
public class PagamentoApplePay : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}
//contrato
public interface IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor);
}
