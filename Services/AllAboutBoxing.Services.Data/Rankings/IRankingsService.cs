namespace AllAboutBoxing.Services.Data.Rankings
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.Rankings;

    public interface IRankingsService
    {
        IEnumerable<RankingsInListViewModel> GetAll();
    }
}
