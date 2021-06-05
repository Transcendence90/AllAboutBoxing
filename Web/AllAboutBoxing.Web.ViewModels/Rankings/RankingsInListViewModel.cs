namespace AllAboutBoxing.Web.ViewModels.Rankings
{
    using AllAboutBoxing.Data.Models;

    public class RankingsInListViewModel
    {
        public virtual Boxer Boxer { get; set; }

        public int WeightClassId { get; set; }

        public string DivisionName { get; set; }

        public string BoxerName { get; set; }

        public int Rank { get; set; }
    }
}
