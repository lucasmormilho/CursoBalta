namespace Balta.ContentContext
{

    //precisa de um objetivo para intermediar
    //pois não sabemos a ordem dos curso
    //ordem de crescimento

    public class CarreerItem
    {
        //construtor
        public CarreerItem
        (
            int order,
            string title,
            string description,
            Course course)
        {
            if (course == null)
            {
                throw new Exception("o curso não pode ser nulo");
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}