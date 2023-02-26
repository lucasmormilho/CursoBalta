namespace Balta.ContentContext
{
    public class Carreer : Content
    {
        //lista iniciada
        public Carreer(string title, string url)
            : base(title, url) //passando para classe pai
        {
            Items = new List<CarreerItem>();
        }

        //sempre que usar listas
        //deve inicia-las com um construtor
        public IList<CarreerItem> Items { get; set; }

        //total de curso é igual a quantidade de items
        //usando expression body
        public int TotalCourses => Items.Count;


    }




}