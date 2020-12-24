namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.WeightClasses;

    public class WeightClassesService : IWeightClassesService
    {
        private readonly IDeletableEntityRepository<WeightClass> weightClassesRepository;

        public WeightClassesService(
            IDeletableEntityRepository<WeightClass> weightClassesRepository)
        {
            this.weightClassesRepository = weightClassesRepository;
        }

        public IEnumerable<WeightClassInListViewModel> GetAll()
        {
            var weightClasses = this.weightClassesRepository.AllAsNoTracking()
                .OrderByDescending(x => x.WeightLimit)
                .Select(x => new WeightClassInListViewModel
                {
                    Id = x.Id,
                    Division = x.Division,
                    Weightlimit = x.WeightLimit,
                    Established = x.Established,
                });

            return weightClasses;
        }

        public T GetById<T>(int id)
        {
            var weightClass = this.weightClassesRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return weightClass;
        }
    }
}
