using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{

    //precisa de um objetivo para intermediar
    //pois não sabemos a ordem dos curso
    //ordem de crescimento

    public class CarreerItem : Base
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
                AddNotificarion(new Notification("Course", "Curso inválido"));
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