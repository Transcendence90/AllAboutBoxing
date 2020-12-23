namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using AllAboutBoxing.Data.Common.Models;

    public class Boxer : BaseDeletableModel<int>
    {
        public Boxer()
        {
            this.Bouts = new HashSet<Bout>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Age { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        [Required]
        [ForeignKey(nameof(WeightClass))]
        public int WeightClassId { get; set; }

        public virtual WeightClass WeightClass { get; set; }

        [Required]
        [ForeignKey(nameof(Record))]
        public int RecordId { get; set; }

        public virtual Record Record { get; set; }

        [ForeignKey(nameof(Champion))]
        public int? ChampionId { get; set; }

        public virtual Champion Champion { get; set; }

        [ForeignKey(nameof(HallOfFame))]
        public int? HallOfFameId { get; set; }

        public virtual HallOfFame HallOfFame { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Residence { get; set; }

        public string Debut { get; set; }

        public string BirthDate { get; set; }

        public string DeathDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Height { get; set; }

        [Required]
        [MaxLength(50)]
        public string Reach { get; set; }

        public virtual ICollection<Bout> Bouts { get; set; }
    }
}
