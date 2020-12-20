namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Web.ViewModels.Boxers;

    public class BoxersService : IBoxersService
    {
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;

        public BoxersService(IDeletableEntityRepository<Boxer> boxersRepository)
        {
            this.boxersRepository = boxersRepository;
        }

        public IEnumerable<BoxerInListViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var boxers = this.boxersRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new BoxerInListViewModel
                {
                    Id = x.Id,
                    BoxerName = x.Name,
                    BoxerImageUrl = x.ImageUrl,
                }).ToList();

            return boxers;
        }

        public int GetCount()
        {
            return this.boxersRepository.All().Count();
        }
    }
}
