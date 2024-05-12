using Fitness.Web.Helpers;
using Fitness.Web.Models;
using GymApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fitness.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        GymDbContext db = new GymDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //bu bir yorumdur

        public IActionResult Index() //if we want to return to another page we should use ıactionresult (return view ile bir yerlere yönlendiriyoruz) gerek yoksa void kullanıyoruz zaten
                                     //IActionResult bir arayüzdür, dönüş olarak özel bir yanıt oluşturabiliriz, ActionResult'u kullandığınızda bir Görünümü veya kaynağı döndürmek için yalnızca önceden tanımlanmış olanları döndürebilirsiniz. IActionResult ile bir yanıt veya hata da döndürebiliriz. Öte yandan, ActionResult soyut bir sınıftır ve miras alan özel bir sınıf oluşturmanız gerekir.
        {
            var mainpage = db.MainPages.FirstOrDefault();
            return View(mainpage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //public ActionResult ContactMessage(int id)
        //{
        //    var ContactMessageUser = db.ContactMessages.Find(id); //database le indekslenmiş
        //    //böyle bir trainer olmayabilir ondan
        //    if (ContactMessageUser == null)
        //    {
        //        return RedirectToAction("Index"); // eğer böle bir veri yoksa ana sayfaya geri gitsin varsa return view ile trainerı gönderiyoruz zaten
        //    }
        //    return View();
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken] //token çalınmaması için web güvenliği için yapılan
        //public ActionResult ContactMessage(ContactMessage model) //model değişken adı ama genelde dışardan geliyosa model diye tanımlarız
        //{
        //    if (ModelState.IsValid)
        //    {
        //        model.Status = true; 
        //        model.CreatedDate = DateTime.Now;
        //        model.CreatedBy = 0;
        //        model.Deleted = false; 
        //        db.ContactMessages.Add(model);
        //        db.SaveChanges();

        //    }
        //        MailSender.SendMailContact(model.FirstName, model.LastName, model.Mail);

        //    return View();
        //}

    }
}