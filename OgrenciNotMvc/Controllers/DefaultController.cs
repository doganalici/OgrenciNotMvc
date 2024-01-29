using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;

namespace OgrenciNotMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcOkulEntities3 db=new DbMvcOkulEntities3();

        public ActionResult Index()
        {
            var Dersler=db.TBLDERSLER.ToList();
            return View(Dersler);
        }

        [HttpGet]
        public ActionResult YeniDers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniDers(TBLDERSLER p) 
        {
            db.TBLDERSLER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}