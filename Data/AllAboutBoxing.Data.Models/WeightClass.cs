namespace AllAboutBoxing.Data.Models
{
    using AllAboutBoxing.Data.Models.Enumerations;

    public class WeightClass
    {
        public int Id { get; set; }

        public Division Division { get; set; }

        public float Kg { get; set; }

        public float Lb { get; set; }

        public int Established { get; set; }
    }
}
