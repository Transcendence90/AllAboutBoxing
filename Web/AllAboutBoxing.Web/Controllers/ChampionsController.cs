﻿namespace AllAboutBoxing.Web.Controllers
{
    using AllAboutBoxing.Services.Data;
    using AllAboutBoxing.Web.ViewModels.Champions;
    using Microsoft.AspNetCore.Mvc;

    public class ChampionsController : Controller
    {
        private readonly IChampionsService championsService;

        public ChampionsController(IChampionsService championsService)
        {
            this.championsService = championsService;
        }

        public IActionResult Index()
        {
            var viewModel = new ChampionsListViewModel
            {
                ChampionsCount = this.championsService.GetCount(),
                Champions = this.championsService.GetAll(),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            return this.Redirect($"/Boxers/ById/{id}");
        }
    }
}
