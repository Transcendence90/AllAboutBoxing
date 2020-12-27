namespace AllAboutBoxing.Web.ViewModels.Boxers
{
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;

    public class BoxerInListViewModel : IMapFrom<Boxer>
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string CountryFlagUrl { get; set; }
    }
}
