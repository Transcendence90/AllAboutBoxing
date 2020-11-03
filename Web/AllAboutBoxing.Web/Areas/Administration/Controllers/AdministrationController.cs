namespace AllAboutBoxing.Web.Areas.Administration.Controllers
{
    using AllAboutBoxing.Common;
    using AllAboutBoxing.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
