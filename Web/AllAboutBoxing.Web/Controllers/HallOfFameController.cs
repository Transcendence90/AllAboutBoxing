namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data;
    using AllAboutBoxing.Web.ViewModels.HallOfFame;
    using Microsoft.AspNetCore.Mvc;

    public class HallOfFameController : Controller
    {
        private readonly IHallOfFameService hallOfFameService;

        public HallOfFameController(IHallOfFameService hallOfFameService)
        {
            this.hallOfFameService = hallOfFameService;
        }

        public IActionResult Index(int id = 1)
        {
            const int itemsPerPage = 1;

            var viewModel = new HallOfFameBoxersListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                BoxersCount = this.hallOfFameService.GetCount(),
                HallOfFameBoxers = this.hallOfFameService.GetAll(id, itemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            return this.Redirect($"/Boxers/ById/{id}");
        }
    }
}
