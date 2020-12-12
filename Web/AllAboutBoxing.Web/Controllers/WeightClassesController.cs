namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data;
    using AllAboutBoxing.Web.ViewModels.WeightClasses;
    using Microsoft.AspNetCore.Mvc;

    public class WeightClassesController : Controller
    {
        private readonly IWeightClassesService weightClassesService;

        public WeightClassesController(IWeightClassesService weightClassesService)
        {
            this.weightClassesService = weightClassesService;
        }

        public IActionResult WeightClasses()
        {
            var viewModel = new WeightClassesListViewModel
            {
                WeightClasses = this.weightClassesService.GetAll(),
            };

            return this.View(viewModel);
        }
    }
}
