namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.Champions;

    public interface IChampionsService
    {
        IEnumerable<ChampionInListViewModel> GetAll();

        int GetCount();

        T GetById<T>(int id);
    }
}
