using System.Collections.Generic;
using System.Linq;

namespace PaymentList;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        IList<Payment> payments = new List<Payment>();
        IEnumerable<Payment> payments2 = new List<Payment>();
        //ienumerable faz mais sentido se não quiser que alguem insera
        //algo na sua lista
        payments.Add(new Payment(1));
        payments.Add(new Payment(2));
        payments.Add(new Payment(3));
        payments.Add(new Payment(4));
        payments.Add(new Payment(5));

        foreach (var item in payments)
        {

            System.Console.WriteLine(item.Id);
        }

        //add range
        var paidPayments = new List<Payment>();
        paidPayments.AddRange(payments);

        //Where tras uma lista
        var paymentWhere = payments.Where(x => x.Id == 3);
        foreach (var item in paymentWhere)
        {
            System.Console.WriteLine(item.Id);
        }

        //First tras um item só
        var paymentFirst = payments.First(x => x.Id == 3);
        System.Console.WriteLine(paymentFirst.Id);

        //remove
        payments.Remove(paymentFirst);
        foreach (var item in payments)
        {
            System.Console.WriteLine(item.Id);
        }

        //Any
        var exists = payments.Any(x => x.Id == 3);
        System.Console.WriteLine(exists);

        //skip
        foreach (var item in payments.Skip(1))
        {
            System.Console.WriteLine(item.Id);
        }

        //take
        foreach (var item in payments.Take(2))
        {
            System.Console.WriteLine(item.Id);
        }

        //conversão
        payments.AsEnumerable();
        payments.ToArray();


    }
}

public class Payment
{
    public int Id { get; set; }

    public Payment(int id)
    {
        Id = id;
    }
}
