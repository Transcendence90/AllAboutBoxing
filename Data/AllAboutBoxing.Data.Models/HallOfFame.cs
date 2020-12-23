namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;

    using AllAboutBoxing.Data.Common.Models;

    public class HallOfFame : BaseDeletableModel<int>
    {
        public HallOfFame()
        {
            this.HallOfFameBoxers = new HashSet<Boxer>();
        }

        public string Description { get; set; }

        public string BoxerPicUrl { get; set; }

        public virtual ICollection<Boxer> HallOfFameBoxers { get; set; }
    }
}
