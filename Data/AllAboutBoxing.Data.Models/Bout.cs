using AllAboutBoxing.Data.Models.Enumerations;

namespace AllAboutBoxing.Data.Models
{
    public class Bout
    {
        public int FirstBoxerId { get; set; }

        public int SecondBoxerId { get; set; }

        public WayOfFinish WayOfFinish { get; set; }
    }
}
