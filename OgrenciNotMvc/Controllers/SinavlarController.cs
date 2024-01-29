using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;

namespace OgrenciNotMvc.Controllers
{
    public class SinavlarController : Controller
    {
        DbMvcOkulEntities3 db=new DbMvcOkulEntities3();
        // GET: Sinavlar
        public ActionResult Index()
        {
            var Notlar=db.TBLNOTLAR.ToList();
            return View(Notlar);
        }
    }
}