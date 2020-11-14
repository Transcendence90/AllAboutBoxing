namespace AllAboutBoxing.Data.Models
{
    using AllAboutBoxing.Data.Common.Models;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BoxerWeightClass : BaseDeletableModel<int>
    {
        [ForeignKey(nameof(WeightClass))]
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }
    }
}
