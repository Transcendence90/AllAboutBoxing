namespace AllAboutBoxing.Web.ViewModels.Boxers
{
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using System;

    public class BoxerBoutsViewModel : IMapFrom<Bout>
    {
        public int Id { get; set; }

        public string OpponentName { get; set; }

        public string WayOfFinish { get; set; }

        public string BoutDate { get; set; }

        public DateTime DateOfBout => DateTime.Parse(this.BoutDate);

        public string Place { get; set; }

        public string TitlesInFight { get; set; }
    }
}
