using Balta.ContentContext;

namespace Balta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var course = new Course();
        foreach (var item in course.Modules)
        {

        }
    }
}
