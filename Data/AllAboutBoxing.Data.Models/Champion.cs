namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;

    using AllAboutBoxing.Data.Common.Models;

    public class Champion : BaseDeletableModel<int>
    {
        public Champion()
        {
            this.Champions = new HashSet<Boxer>();
        }

        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public string Organization { get; set; }

        public virtual ICollection<Boxer> Champions { get; set; }
    }
}
