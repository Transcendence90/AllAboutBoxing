namespace AllAboutBoxing.Services.Data
{
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Country> countriesRepository;
        private readonly IDeletableEntityRepository<WeightClass> weightClassesRepository;
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;
        private readonly IDeletableEntityRepository<Champion> championsRepository;

        public GetCountsService(
            IDeletableEntityRepository<Country> countriesRepository,
            IDeletableEntityRepository<WeightClass> weightClassesRepository,
            IDeletableEntityRepository<Boxer> boxersRepository,
            IDeletableEntityRepository<Champion> championsRepository)
        {
            this.countriesRepository = countriesRepository;
            this.weightClassesRepository = weightClassesRepository;
            this.boxersRepository = boxersRepository;
            this.championsRepository = championsRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                CountriesCount = this.countriesRepository.All().Count(),
                WeightClassesCount = this.weightClassesRepository.All().Count(),
                BoxersCount = this.boxersRepository.All().Count(),
                ChampionsCount = this.championsRepository.All().Count(),
            };

            return data;
        }
    }
}
