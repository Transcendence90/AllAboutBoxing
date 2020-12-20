namespace AllAboutBoxing.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ChampionsController : Controller
    {
        public IActionResult Champions()
        {
            return this.View();
        }
    }
}
