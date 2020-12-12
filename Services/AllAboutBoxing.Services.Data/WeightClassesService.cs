namespace AllAboutBoxing.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
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
                .OrderByDescending(x => x.Id)
                .Select(x => new WeightClassInListViewModel
                {
                    Division = x.Division,
                    Weightlimit = x.WeightLimit,
                    Established = x.Established,
                }).ToList();

            return weightClasses;
        }
    }
}
