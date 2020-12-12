namespace AllAboutBoxing.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class FightersController : Controller
    {
        public IActionResult Fighters()
        {
            return this.View();
        }
    }
}
