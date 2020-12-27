namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.Boxers;

    public interface IBoxersService
    {
        IEnumerable<BoxerInListViewModel> GetAll(int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id);

        T GetByName<T>(string name);
    }
}
