using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta;
class Program
{
    //pacote flunt do balta
    //https://github.com/andrebaltieri/Flunt
    //dotnet add package flunt

    static void Main(string[] args)
    {
        //nova lista de artigos
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));
        // foreach (var item in articles)
        // {
        //     System.Console.WriteLine(item.Id);
        //     System.Console.WriteLine(item.Title);
        //     System.Console.WriteLine(item.Url);
        //     System.Console.WriteLine("----------");
        // }

        //novos cursos
        var courses = new List<Course>();
        var courseOop = new Course("Fundamentos OOP", "fundamento-oop");
        var courseCsharp = new Course("Fundamentos C#", "fundamento-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamento-aspnet");
        courses.Add(courseOop);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);



        //nova carreira
        var careers = new List<Carreer>();
        var careerDotNet = new Carreer("Especialista .NET", "especialista-dotnet");
        var careeritem2 = new CarreerItem(2, "Aprenda OOP", "", null);
        var careeritem = new CarreerItem(1, "Comece por aqui", "", courseCsharp);
        var careeritem3 = new CarreerItem(3, "Aprenda .NET", "", courseAspNet);
        careerDotNet.Items.Add(careeritem2);
        careerDotNet.Items.Add(careeritem3);
        careerDotNet.Items.Add(careeritem);
        careers.Add(careerDotNet);
        foreach (var career in careers)
        {
            System.Console.WriteLine(career.Title);
            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                System.Console.WriteLine($"{item.Order} - {item.Title}");
                System.Console.WriteLine(item.Course?.Title);
                System.Console.WriteLine(item.Course?.Level);

                foreach (var notification in item.Notifications)
                {
                    System.Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }

            //criar uma assinatura para o aluno
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }

    }
}
