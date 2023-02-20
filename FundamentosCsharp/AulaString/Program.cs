using System.Text;

namespace AulaString;
class Program
{
    static void Main(string[] args)
    {
        #region GUID

        Console.Clear();

        var id = Guid.NewGuid();
        Console.WriteLine(id);

        id.ToString();
        Console.WriteLine(id.ToString().Substring(0, 8));

        id = new Guid("23008f35-6030-4386-8f87-daef76837cf8");
        Console.WriteLine(id);

        id = new Guid();
        System.Console.WriteLine(id);

        #endregion

        #region StringFormat

        var price = 10.2;
        var texto = string.Format("O preço é {0} na promoção", price);
        System.Console.WriteLine(texto);
        var texto2 = string.Format($@"O preço é {price} na promoção, 
        com multiplas linhas
        ");
        System.Console.WriteLine(texto2);

        #endregion

        #region ComparaString

        var texto3 = "Testando";
        System.Console.WriteLine(texto3.CompareTo("Testando"));
        System.Console.WriteLine(texto3.Contains("testando"));
        //ignorando o case sensitive
        System.Console.WriteLine(texto3.Contains("testando", StringComparison.OrdinalIgnoreCase));

        #endregion

        #region StringBuilder

        //melhor usar stringbuilder para não criar varias variaveis
        var texto4 = new StringBuilder();
        texto4.Append("Este texto é um teste");
        texto4.Append(" AQUI");
        System.Console.WriteLine(texto4.ToString());

        #endregion
    }
}
