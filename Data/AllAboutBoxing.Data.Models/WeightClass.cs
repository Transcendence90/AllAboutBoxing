namespace AllAboutBoxing.Data.Models
{
    using System.Collections.Generic;

    using AllAboutBoxing.Data.Models.Enumerations;

    public class WeightClass
    {
        public WeightClass()
        {
            this.Boxers = new HashSet<BoxerWeightClass>();
        }

        public int Id { get; set; }

        public Division Division { get; set; }

        public float Kg { get; set; }

        public float Lb { get; set; }

        public int Established { get; set; }

        public virtual ICollection<BoxerWeightClass> Boxers { get; set; }
    }
}
