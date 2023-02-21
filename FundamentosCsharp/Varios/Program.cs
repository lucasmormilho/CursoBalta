using System.Globalization;

namespace Varios;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //datas
        var data = DateTime.Now;
        var formatada = string.Format("{0:r}", data);
        Console.WriteLine(formatada);

        //acrescentar algo na data
        var dia = data.AddDays(12);
        Console.WriteLine(dia);

        //culture info
        var br = new CultureInfo("pt-BR");
        var pt = new CultureInfo("pt-PT");
        var en = new CultureInfo("en-US");
        var atual = CultureInfo.CurrentCulture;
        System.Console.WriteLine(DateTime.Now.ToString("D", pt));
        System.Console.WriteLine(DateTime.Now.ToString("D", br));
        System.Console.WriteLine(DateTime.Now.ToString("D", en));
        System.Console.WriteLine(DateTime.Now.ToString("D", atual));

        //dias em um mes
        System.Console.WriteLine(DateTime.DaysInMonth(2023, 2));

        //fim de semana ou não
        System.Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

        //é horario de verão
        System.Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        //moedas
        //definindo cultura
        decimal valor = 16.25m;
        System.Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        System.Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
        System.Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        decimal valorLongo = 10536.25m;
        System.Console.WriteLine(valorLongo.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
        System.Console.WriteLine(valorLongo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        System.Console.WriteLine(valorLongo.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
        System.Console.WriteLine(valorLongo.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

        decimal valorArredondado = 10536.25m;
        System.Console.WriteLine(Math.Round(valorArredondado));
        System.Console.WriteLine(Math.Ceiling(valorArredondado));
        System.Console.WriteLine(Math.Floor(valorArredondado));

        //array e listas
        var meuArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        System.Console.WriteLine(meuArray[4]);
        foreach (int item in meuArray)
        {
            System.Console.WriteLine(item);

        };

        //array
        //com struct
        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() { Id = 666, Nome = "Andre" };
        foreach (var func in funcionarios)
        {
            System.Console.WriteLine(func.Id);
            System.Console.WriteLine(func.Nome);

        }

        //exceptions
        //System.IndexOutOfRangeException:
        var arr = new int[3];

        try
        {
            for (var index = 0; index < 10; index++)
            {
                System.Console.WriteLine(arr[index]);
            }
        }
        catch (IndexOutOfRangeException e) //ordem de prioridade
        {
            System.Console.WriteLine("Ops, algo deu errado:");
            System.Console.WriteLine("Detalhes: " + e.InnerException);
            System.Console.WriteLine("Detalhes: " + e.Message);
        }

        catch (Exception e)
        {
            System.Console.WriteLine("Ops, algo deu errado:");
            System.Console.WriteLine("Detalhes: " + e.InnerException);
            System.Console.WriteLine("Detalhes: " + e.Message);
        }

        //criando uma exception
        try
        {
            Salvar("");
        }
        catch (IndexOutOfRangeException e) //ordem de prioridade
        {
            System.Console.WriteLine("Ops, algo deu errado:");
            System.Console.WriteLine("Detalhes: " + e.Message);
        }
        catch (ArgumentNullException e)
        {
            System.Console.WriteLine("Falha ao cadastrar texto:");
            System.Console.WriteLine("Detalhes: " + e.Message);
        }

        catch (Exception e)
        {
            System.Console.WriteLine("Ops, algo deu errado:");
            System.Console.WriteLine("Detalhes: " + e.Message);
        }
        finally
        {
            System.Console.WriteLine("Chegou ao fim!");
        }



    }

    //array
    //com struct
    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }

    private static void Salvar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
    }
}
