namespace AllAboutBoxing.Web.ViewModels.Champions
{
    using System.Collections.Generic;

    public class ChampionsListViewModel
    {
        public IEnumerable<ChampionInListViewModel> Champions { get; set; }

        public int ChampionsCount { get; set; }
    }
}
