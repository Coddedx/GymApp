using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Web.Areas.Management.Controllers
{
    public class CategoryController : Controller
    {
        GymDbContext db = new GymDbContext();
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = db.Categories
               .Where(c => c.Deleted == false) //silinmemiş olanları getir
               .ToList();

           // var category = db.Categories.FirstOrDefault();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var categories = db.Categories
                .Include("Courses")
                .FirstOrDefault(c => c.Id == id); 
 
            //böyle bir trainer olmayabilir ondan            
            if (categories == null)
            {
                return RedirectToAction(nameof(Index)); // eğer böle bir veri yoksa ana sayfaya geri gitsin 
            }
            return View(categories);
        }

            // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Status = true;
                    model.CreatedDate = DateTime.Now;
                    model.CreatedBy = 0;
                    model.Deleted = false; 
                    
                    model.Title = model.Title;
                    model.Description = model.Description;
                    model.ImageUrl = null;
                    db.Categories.Add(model);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
