namespace AllAboutBoxing.Data.Models
{
    using System;

    using AllAboutBoxing.Data.Common.Models;

    public class Bout : BaseDeletableModel<int>
    {
        public int FirstBoxerId { get; set; }

        public Boxer FirstBoxer { get; set; }

        public int SecondBoxerId { get; set; }

        public Boxer SecondBoxer { get; set; }

        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int Rounds { get; set; }

        public string WayOfFinish { get; set; }

        public DateTime PlayedOn { get; set; }

        public string Place { get; set; }
    }
}
