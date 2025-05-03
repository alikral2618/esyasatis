using esyasatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace esyasatis.Controllers
{
    public class kullaniciController : Controller
    {
        // GET: kullanici
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult kullaniciEkle()
        {
            return View();

        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult kullaniciEkle(Kullanici p)
        {
            c.kullanicis.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index", "Home");

        }




    }
}