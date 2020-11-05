using AllAboutBoxing.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class Ranking
    {
        public int Id { get; set; }

        [ForeignKey(nameof(WeightClass))]
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public Organization Organization { get; set; }
    }
}
