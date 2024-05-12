using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.Web.Areas.Management.Controllers
{
    public class MainPageController : Controller
    {
        GymDbContext db = new GymDbContext();
        // GET: MainPageController
        public ActionResult Index()
        {
            var maingage = db.MainPages.FirstOrDefault();
            return View(maingage);
        }

        // GET: MainPageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: MainPageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
