using Microsoft.AspNetCore.Mvc;

namespace AllAboutBoxing.Web.Controllers
{
    public class ChampionsController : Controller
    {
        public IActionResult Champions()
        {
            return this.View();
        }
    }
}
