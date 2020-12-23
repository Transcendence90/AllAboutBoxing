namespace AllAboutBoxing.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Record
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public virtual Boxer Boxer { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int Draws { get; set; }

        public int Kos { get; set; }

        public int? NoContests { get; set; }
    }
}
