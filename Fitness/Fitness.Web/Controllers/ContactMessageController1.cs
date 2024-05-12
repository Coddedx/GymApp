using Fitness.Web.Helpers;
using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.Web.Controllers
{
    public class ContactMessageController1 : Controller
    {
        GymDbContext db = new GymDbContext();

        // GET: ContactMessageController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactMessageController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactMessageController1/Create
        public ActionResult Create(int id)
        {
            var ContactMessageUser = db.ContactMessages.Find(id); //database le indekslenmiş
            //böyle bir trainer olmayabilir ondan
            if (ContactMessageUser == null)
            {
                return RedirectToAction("Index"); // eğer böle bir veri yoksa ana sayfaya geri gitsin varsa return view ile trainerı gönderiyoruz zaten
            }
            return View();
        }

        // POST: ContactMessageController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactMessage model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Status = true;
                    model.CreatedDate = DateTime.Now;
                    model.CreatedBy = 0;
                    model.Deleted = false;
                    db.ContactMessages.Add(model);
                    db.SaveChanges();

                }
                MailSender.SendMailContact(model.FirstName, model.LastName, model.Mail);
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ContactMessageController1/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ContactMessageController1/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ContactMessageController1/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ContactMessageController1/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
