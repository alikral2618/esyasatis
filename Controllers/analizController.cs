using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using esyasatis.Entities;
namespace esyasatis.Controllers
{
    public class analizController : Controller
    {
        // GET: analiz
        Context c = new Context();

        public ActionResult Index()
        {

            var deger1 = c.Uruns.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.kategoris.Count().ToString();
            ViewBag.d1 = deger2;


            var yapilacaklar = c.analizs.ToList();
            return View(yapilacaklar);
        }
    }
}