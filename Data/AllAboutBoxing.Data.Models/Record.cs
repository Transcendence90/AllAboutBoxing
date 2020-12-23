namespace AllAboutBoxing.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Record
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public virtual Boxer Boxer { get; set; }

        [Required]
        public int Wins { get; set; }

        [Required]
        public int Loses { get; set; }

        [Required]
        public int Draws { get; set; }

        public int Kos { get; set; }

        public int? NoContests { get; set; }
    }
}
