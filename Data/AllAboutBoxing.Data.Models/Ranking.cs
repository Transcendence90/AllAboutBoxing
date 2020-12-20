namespace AllAboutBoxing.Data.Models
{

    using AllAboutBoxing.Data.Common.Models;
    using System.Collections.Generic;

    public class Ranking : BaseModel<int>
    {
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public string Organization { get; set; }
    }
}
