namespace AllAboutBoxing.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class RankingsController : Controller
    {
        public IActionResult Rankings()
        {
            return this.View();
        }
    }
}
