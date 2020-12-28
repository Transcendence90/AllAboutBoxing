namespace AllAboutBoxing.Services.Data.Rankings
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Web.ViewModels.Rankings;

    public class RankigsService : IRankingsService
    {
        private readonly IRepository<Ranking> rankingsRepository;
        private readonly IDeletableEntityRepository<WeightClass> weightClassesRepository;

        public RankigsService(
            IRepository<Ranking> rankingsRepository,
            IDeletableEntityRepository<WeightClass> weightClassesRepository)
        {
            this.rankingsRepository = rankingsRepository;
            this.weightClassesRepository = weightClassesRepository;
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
                });

            return rankings;
        }
    }
}
