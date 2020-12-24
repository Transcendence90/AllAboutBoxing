namespace AllAboutBoxing.Web.ViewModels.WeightClasses
{
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;

    public class SingleWeightClassViewModel : IMapFrom<WeightClass>
    {
        public int Id { get; set; }

        public string Division { get; set; }

        public string Weightlimit { get; set; }

        public int Established { get; set; }

        public string Description { get; set; }

        public string WeightClassUrlPic { get; set; }
    }
}
