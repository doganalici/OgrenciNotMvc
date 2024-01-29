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
        DbMvcOkulEntities3 db=new DbMvcOkulEntities3();
        // GET: Ogrenciler
        public ActionResult Index()
        {
            var Ogrenciler=db.TBLOGRENCILER.ToList();
            return View(Ogrenciler);
        }

        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            return View();
        }
        [HttpPost]

        public ActionResult YeniOgrenci(TBLOGRENCILER p3)
        {
            db.TBLOGRENCILER.Add(p3);
            db.SaveChanges();
            return View();
        }
    }

}