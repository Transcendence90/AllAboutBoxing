using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class Record
    {
        public Record()
        {
            this.Bouts = new HashSet<Bout>();
        }

        public int Id { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public byte Wins { get; set; }

        public byte Loses { get; set; }

        public byte Draws { get; set; }

        public byte NoContests { get; set; }

        public byte Knockouts { get; set; }

        public byte KnockoutsPercentage { get; set; }

        public int RoundsPlayed { get; set; }

        public virtual ICollection<Bout> Bouts { get; set; }
    }
}
