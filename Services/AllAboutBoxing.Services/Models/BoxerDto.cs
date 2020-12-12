namespace AllAboutBoxing.Services.Models
{
    using AllAboutBoxing.Data.Models;

    public class BoxerDto
    {
        public string BoxerName { get; set; }

        public int Age { get; set; }

        public Record Record { get; set; }

        public string ImageUrl { get; set; }

        public Country Country { get; set; }

        public int Height { get; set; }

        public int Reach { get; set; }
    }
}
