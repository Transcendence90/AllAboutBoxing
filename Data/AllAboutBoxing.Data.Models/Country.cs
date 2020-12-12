namespace AllAboutBoxing.Data.Models
{
    using AllAboutBoxing.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string FlagUrl { get; set; }
    }
}
