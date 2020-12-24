namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AllAboutBoxing.Data.Common.Models;

    public class WeightClass : BaseDeletableModel<int>
    {
        public WeightClass()
        {
            this.Boxers = new HashSet<Boxer>();
        }

        [Required]
        [MaxLength(50)]
        public string Division { get; set; }

        [Required]
        [MaxLength(50)]
        public string WeightLimit { get; set; }

        [Required]
        public int Established { get; set; }

        public string Description { get; set; }

        public string WeightClassUrlPic { get; set; }

        public virtual ICollection<Boxer> Boxers { get; set; }
    }
}
