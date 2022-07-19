using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{

    public class CarrerItem : Base
    {
        public CarrerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido"));
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}