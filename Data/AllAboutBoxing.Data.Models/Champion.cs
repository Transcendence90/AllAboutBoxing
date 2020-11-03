using AllAboutBoxing.Data.Models.Enumerations;

namespace AllAboutBoxing.Data.Models
{
    public class Champion
    {
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public Organization Organization { get; set; }
    }
}
