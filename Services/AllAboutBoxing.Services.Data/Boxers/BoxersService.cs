namespace AllAboutBoxing.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllAboutBoxing.Data.Common.Repositories;
    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;
    using AllAboutBoxing.Web.ViewModels.Boxers;

    public class BoxersService : IBoxersService
    {
        private readonly IDeletableEntityRepository<Boxer> boxersRepository;

        public BoxersService(
            IDeletableEntityRepository<Boxer> boxersRepository)
        {
            this.boxersRepository = boxersRepository;
        }

        public IEnumerable<BoxerInListViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var boxers = this.boxersRepository.AllAsNoTracking()
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new BoxerInListViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    CountryFlagUrl = x.Country.FlagUrl,
                }).ToList();

            return boxers;
        }

        public T GetById<T>(int id)
        {
            var boxer = this.boxersRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return boxer;
        }

        public T GetByName<T>(string name)
        {
            var boxer = this.boxersRepository.AllAsNoTracking()
                .Where(x => x.Name.Contains(name))
                .To<T>().FirstOrDefault();

            return boxer;
        }

        public int GetCount()
        {
            return this.boxersRepository.All().Count();
        }
    }
}
