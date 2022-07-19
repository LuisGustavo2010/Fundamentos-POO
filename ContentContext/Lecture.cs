using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{


    public class Leacture : Base
    {
        public int Order { get; set; }

        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public ContentContext.Enums.EContentLevel Level { get; set; }


    }




}