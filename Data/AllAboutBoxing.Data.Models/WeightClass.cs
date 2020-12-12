namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;

    using AllAboutBoxing.Data.Common.Models;

    public class WeightClass : BaseDeletableModel<int>
    {
        public WeightClass()
        {
            this.Boxers = new HashSet<Boxer>();
        }

        public string Division { get; set; }

        public string WeightLimit { get; set; }

        public int Established { get; set; }

        public virtual ICollection<Boxer> Boxers { get; set; }
    }
}
