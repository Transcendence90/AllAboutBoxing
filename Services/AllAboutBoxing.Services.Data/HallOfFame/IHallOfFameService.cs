namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.HallOfFame;

    public interface IHallOfFameService
    {
        IEnumerable<HallOfFameBoxerInListViewModel> GetAll(int page, int itemsPerPage = 1);

        int GetCount();

        T GetById<T>(int id);
    }
}
