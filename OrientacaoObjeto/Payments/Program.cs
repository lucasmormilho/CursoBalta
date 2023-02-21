namespace Payments;
class Program
{
    static void Main(string[] args)
    {
        //um objeto possui propriedades, metodos e eventos
        //objeto sempre é um tipo referencia
        //só armazena o endereço dos dados
        //na memoria heap

        //tipo valor é na memoria stack

        //struct armazena o valor em si
        //class só o endereço

        Console.WriteLine("Hello, World!");

        //conceito de herança
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        System.Console.WriteLine(pagamentoBoleto.Vencimento);
        System.Console.WriteLine(pagamentoBoleto.NumeroBoleto);

        //polimorfismo
        var pagamento = new Pagamento();
        pagamento.ToString();

        pagamento.DataPagamento = DateTime.Now;
    }

    public class Pagamento
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
        public void Pagar()
        {

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
