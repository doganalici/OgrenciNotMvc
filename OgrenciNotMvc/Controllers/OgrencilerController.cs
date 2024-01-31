using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;

namespace OgrenciNotMvc.Controllers
{
    public class OgrencilerController : Controller
    {
        DbMvcOkulEntities3 db = new DbMvcOkulEntities3();
        // GET: Ogrenciler
        public ActionResult Index()
        {
            var Ogrenciler = db.TBLOGRENCILER.ToList();
            return View(Ogrenciler);
        }

        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler=(from i in db.TBLKULUPLER.ToList()
                                           select new SelectListItem
                                           {
                                               Text=i.KULUPAD,
                                               Value=i.KULUPID.ToString()
                                           }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]

        public ActionResult YeniOgrenci(TBLOGRENCILER p3)
        {
            var klp=db.TBLKULUPLER.Where(m=>m.KULUPID==p3.TBLKULUPLER.KULUPID).FirstOrDefault();
            p3.TBLKULUPLER = klp;
            db.TBLOGRENCILER.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var ogrenci = db.TBLOGRENCILER.Find(id);
            db.TBLOGRENCILER.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = db.TBLOGRENCILER.Find(id);
            return View("OgrenciGetir",ogrenci);
        }

        public ActionResult Guncelle(TBLOGRENCILER p)
        {
            var ogr = db.TBLOGRENCILER.Find(p.OGRENCIID);
            ogr.OGRAD = p.OGRAD;
            ogr.OGRSOYAD = p.OGRSOYAD;
            ogr.OGRFOTOGRAF = p.OGRFOTOGRAF;
            ogr.OGRCINSIYET = p.OGRCINSIYET;
            ogr.OGRKULUP = p.OGRKULUP;
            db.SaveChanges();
            return RedirectToAction("Index", "Ogrenciler");
        }
    }
}



//List<SelectListItem> items = new List<SelectListItem>();

//items.Add(new SelectListItem { Text = "Matematik", Value = "0" });

//items.Add(new SelectListItem { Text = "Fen Bilgisi", Value = "1" });

//items.Add(new SelectListItem { Text = "Atatürk İlke ve İnkılapları", Value = "2" });

//items.Add(new SelectListItem { Text = "Coğrafya", Value = "3" });

//items.Add(new SelectListItem { Text = "Edebiyat", Value = "4" });

//ViewBag.DersAd = items;