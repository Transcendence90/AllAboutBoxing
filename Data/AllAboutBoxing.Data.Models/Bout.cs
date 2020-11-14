namespace AllAboutBoxing.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using AllAboutBoxing.Data.Models.Enumerations;

    public class Bout
    {
        public Bout()
        {
            this.BoxerBouts = new HashSet<BoxerBout>();
        }

        public int Id { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int FirstBoxerId { get; set; }

        public Boxer FirstBoxer { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int SecondBoxerId { get; set; }

        public Boxer SecondBoxer { get; set; }

        [ForeignKey(nameof(WeightClass))]
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int Rounds { get; set; }

        public WayOfFinish WayOfFinish { get; set; }

        public DateTime PlayedOn { get; set; }

        public virtual ICollection<BoxerBout> BoxerBouts { get; set; }
    }
}
