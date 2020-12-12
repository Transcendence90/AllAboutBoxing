namespace AllAboutBoxing.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using AllAboutBoxing.Data.Common.Models;

    public class Boxer : BaseDeletableModel<int>
    {
        public Boxer()
        {
            this.HomeBouts = new HashSet<Bout>();
            this.AwayBouts = new HashSet<Bout>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int BoutId { get; set; }

        public Bout Bout { get; set; }

        [ForeignKey(nameof(Record))]
        public int RecordId { get; set; }

        public Record Record { get; set; }

        public bool IsActive { get; set; }

        public string ImageUrl { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public string Stance { get; set; }

        public DateTime Debut { get; set; }

        public string Height { get; set; }

        public string Reach { get; set; }

        [InverseProperty("FirstBoxer")]
        public virtual ICollection<Bout> HomeBouts { get; set; }

        [InverseProperty("SecondBoxer")]
        public virtual ICollection<Bout> AwayBouts { get; set; }
    }
}
