using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Leacture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Leacture> Lectures { get; set; }
    }
}

