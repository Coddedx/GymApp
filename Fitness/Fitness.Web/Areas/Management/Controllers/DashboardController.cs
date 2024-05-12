using Microsoft.AspNetCore.Mvc;

namespace Fitness.Web.Areas.Management.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
