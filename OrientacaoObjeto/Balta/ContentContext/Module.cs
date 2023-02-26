namespace Balta.ContentContext
{
    public class Module
    {
        //inicializar para não gerar erro
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string title { get; set; }
        public IList<Lecture> Lectures { get; set; }

    }
}