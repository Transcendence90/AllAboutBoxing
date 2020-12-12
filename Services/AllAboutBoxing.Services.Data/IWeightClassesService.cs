namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;

    using AllAboutBoxing.Web.ViewModels.WeightClasses;

    public interface IWeightClassesService
    {
        IEnumerable<WeightClassInListViewModel> GetAll();
    }
}
