namespace PaymentGenerics;
class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        var payment = new Payment();
        var subscription = new Subscription();

        //ao criar um instancia do dataconxte
        //é necessário passar um tipo
        //no caso setado um person
        //tipado como person não posso passar um payment por exemplo
        //var context = new DataContext<Person>();
        //context.Save(person);

        //pode se usar varios tipos genericos no mesmo dataContext
        var contextVarios = new DataContext<Person, Payment, Subscription>();
        contextVarios.Save(person);
        contextVarios.Save(payment);
        contextVarios.Save(subscription);

    }
}

//gravar no banco de dados
//todas as classes
//criar algo generico
//criar um x um generico
//usado muito um T
//normalmente usa uma letra só

public class DataContext<X, Y, Z>
{
    public void Save(X entity)
    {
    }
    public void Save(Y entity)
    {
    }
    public void Save(Z entity)
    {
    }
}

public class Person { }
public class Payment { }
public class Subscription { }
