namespace AllAboutBoxing.Web.ViewModels.News
{
    using System;

    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;

    public class NewsViewModel : IMapFrom<News>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DescriptionOnNewsPage { get; set; }

        public string OriginalUrl { get; set; }

        public string ImageUrl { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
