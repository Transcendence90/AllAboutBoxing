namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data.Rankings;
    using AllAboutBoxing.Web.ViewModels.Rankings;
    using Microsoft.AspNetCore.Mvc;

    public class RankingsController : Controller
    {
        private readonly IRankingsService rankingsService;

        public RankingsController(IRankingsService rankingsService)
        {
            this.rankingsService = rankingsService;
        }

        public IActionResult Rankings()
        {
            var viewModel = new RankigsListViewModel
            {
                Rankings = this.rankingsService.GetAll(),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            return this.Redirect($"/Boxers/ById/{id}");
        }
    }
}
