namespace AllAboutBoxing.Web.ViewModels.HallOfFame
{
    using AllAboutBoxing.Data.Models;

    public class HallOfFameBoxerInListViewModel
    {
        public int Id { get; set; }

        public HallOfFame HallOfFameBoxer { get; set; }

        public string BoxerImageUrl { get; set; }

        public string BoxerName { get; set; }

        public string Description { get; set; }
    }
}
