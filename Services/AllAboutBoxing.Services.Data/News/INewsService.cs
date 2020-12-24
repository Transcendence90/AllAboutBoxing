namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.News;

    public interface INewsService
    {
        IEnumerable<NewsViewModel> GetAllNews<T>(int page, int itemsPerPage);

        T GetById<T>(int id);

        int GetCount();
    }
}
