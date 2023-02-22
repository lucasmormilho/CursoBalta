namespace Payments;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //conceito de herança
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar("123");
        System.Console.WriteLine(pagamentoBoleto.Vencimento);
        System.Console.WriteLine(pagamentoBoleto.NumeroBoleto);

        //polimorfismo
        var pagamento = new Pagamento(); //new molda a variavel
        pagamento.ToString();

        pagamento.DataPagamento = DateTime.Now;

        pagamentoBoleto.PagarComSobreEscrita("666");

        //finalizar o pagamento
        pagamento.Dispose();

        //garantir o finalizar do metodo usando using
        using (var pagamentoComUsing = new Pagamento())
        {
            System.Console.WriteLine("Processamendo pagamento");
        }

    }

    //usando a interface disposable para destuir o objeto
    public class Pagamento : IDisposable
    {
        //1º pilar -- ENCAPSULAMENTO, AGRUPAR
        //2º pilar -- ABSTRAÇÃO (exempo ConsultarSaldoCartao)
        //3º pilar -- HERANÇA
        //4º pilar -- POLIMORFISMO

        //5º modificar acesso --> private, protected, internal e public

        //propriedade ou variaves
        public DateTime Vencimento { get; set; }
        //tipo complexos, evitar tipos primitivos
        public Address? BillingAddress;

        //da para interagir com o objeto
        //não utiliza muito
        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get
            {
                System.Console.WriteLine("Lendo valor"); //viraram metodos
                return _dataPagamento.AddDays(1);
            }
            set
            {
                System.Console.WriteLine("Atribuindo valor"); //viraram metodos
                _dataPagamento = value;
            }
        }


        //metodo ou funções
        public void Pagar(string numero)
        {

        }
        //sobrecarga de metodo com mesmo nome porem com assinatura diferente
        public void Pagar(string numero, DateTime vencimento, bool Pagamento = true)
        {

        }

        //sobreescrita de metodo
        public virtual void PagarComSobreEscrita(string numero)
        {
            System.Console.WriteLine("Pagar");
        }

        //metodo consultor
        //garbage collerctor
        //criar algo e destruir algo quando uma classe esta sendo construida
        //Por exemplo desconectar do bd
        public Pagamento()
        {
            System.Console.WriteLine("iniciando o pagamento");
        }

        //metodo ou funções
        private void ConsultarSaldoCartao()
        {
            //abstracao private
        }
        //Polimorfismo
        public virtual void PagarPolimorfismo()
        {

        }
        //Polimorfismo
        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy");
        }

        //interface para destruir o objeto
        public void Dispose()
        {
            System.Console.WriteLine("Finalizando pagamento");
        }
    }
    //herança
    class PagamentoBoleto : Pagamento
    {
        public string? NumeroBoleto;

        //polimorfismo
        public override void PagarPolimorfismo()
        {
            //regra boleto
        }

        //sobreescrita de metodo
        public override void PagarComSobreEscrita(string numero)
        {
            base.PagarComSobreEscrita(numero); //metodo pai
            System.Console.WriteLine("Pagar boleto"); //metodo sobreescrito
        }

    }
    //herança
    class PagamentoCartaoCredito : Pagamento
    {
        public string? NumeroCartao;

        //polimorfismo
        public override void PagarPolimorfismo()
        {
            //regra cartão
        }
    }

    //tipos complexos
    //evitar usar muitos tipos primitivos
    public class Address
    {
        string? ZipCode;
    }
}
