using Fitness.Web.Helpers;
using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Fitness.Web.Areas.Management.Controllers
{
    public class TrainerController : Controller
    {
        GymDbContext db = new GymDbContext();
        // GET: TrainerController
        public ActionResult Index()
        {
            //where ile silinmemmiş tariner sa gönder soft delete yapıyoruz yani (listeye çevirmeden önce to list ile şartımızı söylememiz lazım)
            //liste olduğunda tablo oluşturuyoruz bunun index inde de template den tablo koyduk
            var trainers =db.Trainers
                .Where(c => c.Deleted == false )
                .ToList();

            return View(trainers);
        }

        // GET: TrainerController/Details/5
        public ActionResult Details(int id)
        {
            var trainer = db.Trainers.Find(id); //database le indekslenmiş
            //böyle bir trainer olmayabilir ondan
            if (trainer == null)
            {
                return RedirectToAction("Index"); // eğer böle bir veri yoksa ana sayfaya geri gitsin varsa return view ile trainerı gönderiyoruz zaten
            }
            return View(trainer);
        }

        // GET: TrainerController/Create
        //indexini oluştuturken post olan değil de bu create ile sağ tık add iew ile oluşturuyoruz 
        public ActionResult Create() //bu sadece sayfayı açıyo (get yani bu get diye de yazılabilir ama default get old için yazmıyoruz) o yüzden httpPost u içine yazıyoruz
        {
            return View();
        }

        // POST: TrainerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken] //token çalınmaması için web güvenliği için yapılan
        public ActionResult Create(Trainer model) //model değişken adı ama genelde dışardan geliyosa model diye tanımlarız
        {
            try //exception alırsak diye try catch içinde yazıyoruz
            {
                if (ModelState.IsValid)//sql den gelen yani modelde gelen değerlerin doğru olup olmadığını kont ediyor
                {
                    model.Status = true; //ilk oluşturulduğununda trainerin statusu doğru olur (aktif)
                    model.CreatedDate = DateTime.Now;
                    model.CreatedBy = 0;
                    model.Deleted = false; //ındex de false demiştik (yeni eklenen trainer silinmemiş olması için false)
                    db.Trainers.Add(model);
                    db.SaveChanges();

                    //mail gönder 
                    MailSender.SendMail(model.FullName, new List<string> { model.Email });

                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: TrainerController/Edit/5
        public ActionResult Edit(int id)  //int id edit butonuna bastığında gelen id mi?????????????????????
                                          //ve post edit inde neden gelen veri trainer model??????????????????????????????
        {
            var trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(trainer);
        }

        // POST: TrainerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Trainer model)  //bu post old için yapılan değişiklikler burda sqle post ediliyor yukardaki get edit metodu sadece gösteriyor o yüzen db.savechanges i burdan yapmamız lazım
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var editTrainer = db.Trainers.Find(model.Id);
                    if (editTrainer == null)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    editTrainer.FullName = model.FullName;
                    editTrainer.Email = model.Email;
                    editTrainer.Phone = model.Phone;
                    editTrainer.Status = model.Status;
                    editTrainer.UpdatedBy =0;
                    editTrainer.UpdatedDate = DateTime.Now;
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

        // GET: TrainerController/Delete/5
        public ActionResult Delete(int id)
        {
            var trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(trainer);
        }

        // POST: TrainerController/Delete/5
        [HttpPost, ActionName("Delete")] //aslında action namein delete old unu ama ismini değiştirdiğimizi söyüyoruz yoksa hata veriyor
                                         //(aynı parametreleri aldığımız için (id) yukardaki delete den farklı ismlnedirmemiz lazım metodu)
        [ValidateAntiForgeryToken]
        public ActionResult DeleteContfirmed(int id)
        {
            try
            {
                var trainer = db.Trainers.Find(id);
                if (trainer==null )
                {
                    return RedirectToAction(nameof(Index));
                }
                trainer.Deleted = true;
                trainer.UpdatedDate = DateTime.Now;
                trainer.UpdatedBy = 0;
                db.SaveChanges();

                //hard delete genelde bunu kullanmayız
                //db.Trainers.Remove(trainer);
                //db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
