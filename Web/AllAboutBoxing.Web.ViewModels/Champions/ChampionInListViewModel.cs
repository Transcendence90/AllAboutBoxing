namespace AllAboutBoxing.Web.ViewModels.Champions
{

    using AllAboutBoxing.Data.Models;

    public class ChampionInListViewModel
    {
        public int Id { get; set; }

        public virtual Champion Champion { get; set; }

        public string ChampionName { get; set; }

        public string ImageUrl { get; set; }

        public string CountryFlagUrl { get; set; }

        public string Organization { get; set; }

        public string WeightClass { get; set; }

        public string WeightLimit { get; set; }
    }
}
