namespace AllAboutBoxing.Services.Data
{
    using AllAboutBoxing.Web.ViewModels.Boxers;
    using System.Collections.Generic;

    public interface IBoxersService
    {
        IEnumerable<BoxerInListViewModel> GetAll(int page, int itemsPerPage = 12);

        int GetCount();
    }
}
