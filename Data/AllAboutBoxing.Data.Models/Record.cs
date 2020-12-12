namespace AllAboutBoxing.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using AllAboutBoxing.Data.Common.Models;

    public class Record : BaseDeletableModel<int>
    {
        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int Draws { get; set; }

        public int? NoContests { get; set; }

        public int Knockouts { get; set; }

        public int KnockoutsPercentage { get; set; }

        public int RoundsPlayed { get; set; }
    }
}
