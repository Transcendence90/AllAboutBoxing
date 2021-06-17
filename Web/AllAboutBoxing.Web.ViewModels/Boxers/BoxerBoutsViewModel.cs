namespace AllAboutBoxing.Web.ViewModels.Boxers
{
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;

    public class BoxerBoutsViewModel : IMapFrom<Bout>
    {
        public int Id { get; set; }

        public string OpponentName { get; set; }

        public string WayOfFinish { get; set; }

        public string BoutDate { get; set; }

        public string Place { get; set; }

        public string TitlesInFight { get; set; }
    }
}
