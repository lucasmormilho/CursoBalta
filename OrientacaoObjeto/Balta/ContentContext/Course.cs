namespace Balta.ContentContext
{
    public class Course : Content
    {
        //inicializar para não gerar erro
        public Course()
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
    }

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

    public class Lecture
    {
        public int Order { get; set; }
        public int Title { get; set; }
    }
}