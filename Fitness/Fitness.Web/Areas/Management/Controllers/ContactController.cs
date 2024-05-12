using Fitness.Web.Helpers;
using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.Web.Areas.Management.Controllers
{
    public class ContactController : Controller
    {
        GymDbContext db = new GymDbContext();

        private readonly IEmailSender _emailSender;

        public ContactController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }


        // GET: ContactController
        public async Task<ActionResult> Index()
        {
            //var receiver = "blackworld752@gmail.com";
            //var subject = "Test";
            //var message = "Hello World";

            //await _emailSender.SendEmailAsync(receiver, subject, message);

            //var contact = db.Contacts.FirstOrDefault();
            //return View(contact);
            var contact = db.Contacts
               .Where(c => c.Deleted == false)
               .ToList();
            return View(contact);
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Status = true;
                    model.CreatedDate = DateTime.Now;
                    model.CreatedBy = 0;
                    model.Deleted = false;
                    db.Contacts.Add(model);
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

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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
