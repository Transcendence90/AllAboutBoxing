namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.HallOfFame;

    public class HallOfFameService : IHallOfFameService
    {
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;
        private readonly IDeletableEntityRepository<HallOfFame> hallOfFameRepository;

        public HallOfFameService(
            IDeletableEntityRepository<Boxer> boxersRepository,
            IDeletableEntityRepository<HallOfFame> hallOfFameRepository)
        {
            this.boxersRepository = boxersRepository;
            this.hallOfFameRepository = hallOfFameRepository;
        }

        public IEnumerable<HallOfFameBoxerInListViewModel> GetAll(int page, int itemsPerPage = 1)
        {
            var hallOfFameBoxers = this.boxersRepository.AllAsNoTracking()
                .Where(x => x.HallOfFameId != null)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new HallOfFameBoxerInListViewModel
                {
                    Id = x.Id,
                    BoxerName = x.Name,
                    BoxerImageUrl = x.HallOfFame.BoxerPicUrl,
                    Description = x.HallOfFame.Description,
                }).ToList();

            return hallOfFameBoxers;
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
            return this.hallOfFameRepository.All().Count();
        }
    }
}
