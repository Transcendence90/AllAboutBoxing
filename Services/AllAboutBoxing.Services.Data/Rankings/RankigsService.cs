namespace AllAboutBoxing.Services.Data.Rankings
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.Rankings;

    public class RankigsService : IRankingsService
    {
        private readonly IRepository<Ranking> rankingsRepository;
        private readonly IDeletableEntityRepository<WeightClass> weightClassesRepository;
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;

        public RankigsService(
            IRepository<Ranking> rankingsRepository,
            IDeletableEntityRepository<WeightClass> weightClassesRepository,
            IDeletableEntityRepository<Boxer> boxersRepository)
        {
            this.rankingsRepository = rankingsRepository;
            this.weightClassesRepository = weightClassesRepository;
            this.boxersRepository = boxersRepository;
        }

        public IEnumerable<RankingsInListViewModel> GetAll()
        {
            var rankings = this.rankingsRepository.AllAsNoTracking()
                .OrderByDescending(x => x.WeightClass.WeightLimit)
                .ThenBy(x => x.Rank)
                .Select(x => new RankingsInListViewModel
                {
                    WeightClassId = x.Id,
                    BoxerName = x.BoxerName,
                    Rank = x.Rank,
                    DivisionName = x.WeightClass.Division,
                    Boxer = this.boxersRepository.AllAsNoTracking().FirstOrDefault(b => b.Name == x.BoxerName),
                });

            return rankings;
        }

        public T GetById<T>(int id)
        {
            var boxer = this.boxersRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return boxer;
        }
    }
}
