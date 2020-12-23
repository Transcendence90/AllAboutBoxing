namespace AllAboutBoxing.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using AllAboutBoxing.Data.Common.Models;

    public class Bout : BaseDeletableModel<int>
    {
        [Required]
        public int BoxerId { get; set; }

        public virtual Boxer Boxer { get; set; }

        [Required]
        [MaxLength(50)]
        public string OpponentName { get; set; }

        [Required]
        public int WeightClassId { get; set; }

        public virtual WeightClass WeightClass { get; set; }

        [Required]
        [MaxLength(20)]
        public string WayOfFinish { get; set; }

        public string BoutDate { get; set; }

        public string Place { get; set; }

        [MaxLength(300)]
        public string TitlesInFight { get; set; }
    }
}
