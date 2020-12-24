namespace AllAboutBoxing.Services.Data.News
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.News;

    public class NewsService : INewsService
    {
        private readonly IRepository<News> newsRepository;

        public NewsService(IRepository<News> newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        IEnumerable<NewsViewModel> INewsService.GetAllNews<T>(int page, int itemsPerPage)
        {
            var news = this.newsRepository.AllAsNoTracking()
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new NewsViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    DescriptionOnNewsPage = x.Description.Substring(0, 300),
                    PublishedOn = x.PublishedOn,
                }).ToList();

            return news;
        }

        public T GetById<T>(int id)
        {
            var newById = this.newsRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return newById;
        }

        public int GetCount()
        {
            return this.newsRepository.All().Count();
        }
    }
}
