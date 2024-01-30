using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0)
        {
            double ilkdeger = sayi1;
            ViewBag.ilkdgr = ilkdeger;

             double ikincideger = sayi2;
            ViewBag.ikncdgr = ikincideger;

            double tplsonuc = sayi1 + sayi2;
            ViewBag.tplsnc = tplsonuc;

            double ckrsonuc = sayi1 - sayi2;
            ViewBag.ckrsnc = ckrsonuc;

            double crpsonuc = sayi1 * sayi2;
            ViewBag.crpsnc = crpsonuc;

            double bolsonuc = sayi1 / sayi2;
            ViewBag.bolsnc = bolsonuc;

             double modsonuc = sayi1 % sayi2;
            ViewBag.modsnc = modsonuc;

            return View();
        }
    }
}