namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data;
    using AllAboutBoxing.Web.ViewModels.Boxers;
    using Microsoft.AspNetCore.Mvc;

    public class BoxersController : Controller
    {
        private readonly IBoxersService boxersService;

        public BoxersController(IBoxersService boxersService)
        {
            this.boxersService = boxersService;
        }

        public IActionResult All(int id = 1)
        {
            const int itemsPerPage = 12;
            var viewModel = new BoxersListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                BoxersCount = this.boxersService.GetCount(),
                Boxers = this.boxersService.GetAll(id, itemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var boxer = this.boxersService.GetById<SingleBoxerViewModel>(id);
            return this.View(boxer);
        }

        public IActionResult SearchByName(string name)
        {
            var boxerViewModel = this.boxersService.GetByName<BoxerInListViewModel>(name);

            if (boxerViewModel == null)
            {
                return this.Redirect("All");
            }

            return this.View(boxerViewModel);
        }
    }
}
