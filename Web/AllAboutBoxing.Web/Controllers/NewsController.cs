namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data;
    using AllAboutBoxing.Web.ViewModels.News;
    using Microsoft.AspNetCore.Mvc;

    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public IActionResult News(int id = 1)
        {
            const int itemsPerPage = 5;

            var viewModel = new NewsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                NewsCount = this.newsService.GetCount(),
                NewsList = this.newsService.GetAllNews<NewsViewModel>(id, itemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult NewsById(int id)
        {
            var newById = this.newsService.GetById<NewsViewModel>(id);
            return this.View(newById);
        }
    }
}
