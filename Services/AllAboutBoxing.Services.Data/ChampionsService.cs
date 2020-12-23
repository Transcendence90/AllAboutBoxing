namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.Champions;

    public class ChampionsService : IChampionsService
    {
        private readonly IDeletableEntityRepository<Champion> championsRepository;
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;

        public ChampionsService(
            IDeletableEntityRepository<Champion> championsRepository,
            IDeletableEntityRepository<Boxer> boxersRepository)
        {
            this.championsRepository = championsRepository;
            this.boxersRepository = boxersRepository;
        }

        public IEnumerable<ChampionInListViewModel> GetAll()
        {
            var champions = this.boxersRepository.AllAsNoTracking()
               .Where(x => x.ChampionId != null)
               .Select(x => new ChampionInListViewModel
               {
                   Id = x.Id,
                   ChampionName = x.Name,
                   ImageUrl = x.ImageUrl,
                   CountryFlagUrl = x.Country.FlagUrl,
                   Organization = x.Champion.Organization,
                   WeightLimit = x.WeightClass.WeightLimit,
               }).OrderByDescending(x => x.WeightLimit)
               .ToList();

            return champions;
        }

        public T GetById<T>(int id)
        {
            var boxer = this.boxersRepository.AllAsNoTracking()
               .Where(x => x.Id == id)
               .To<T>().FirstOrDefault();

            return boxer;
        }

        public int GetCount()
        {
            return this.championsRepository.All().Count();
        }
    }
}
