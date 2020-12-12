namespace AllAboutBoxing.Data.Models
{

    using AllAboutBoxing.Data.Common.Models;

    public class Ranking : BaseModel<int>
    {
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public string Organization { get; set; }
    }
}
