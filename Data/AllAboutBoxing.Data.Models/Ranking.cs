namespace AllAboutBoxing.Data.Models
{

    using AllAboutBoxing.Data.Common.Models;

    public class Ranking : BaseModel<int>
    {
        public int WeightClassId { get; set; }

        public virtual WeightClass WeightClass { get; set; }

        public string Organization { get; set; }

        public int Rank { get; set; }

        public string BoxerName { get; set; }
    }
}
