using esyasatis.Concrt;
using esyasatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace esyasatis.Controllers
{
    public class AdminKategoriController : Controller
    {
        // GET: AdminKategori
       // KategoriRepository kategoriRepository = new KategoriRepository();
        Context c = new Context();
        public ActionResult Index()
        {

            var kategori = c.kategoris.ToList();
            return View(kategori);
        }
        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(kategori p)
        {

            c.kategoris.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
       
        public ActionResult kategoriSil(int id)
        {
            var deger = c.kategoris.Find(id);
            c.kategoris.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult KategoriGuncelle(int id)
        {
            List<SelectListItem> deger1 = (from x in c.kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ad,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var ktgdeger = c.kategoris.Find(id);
            return View("KategoriGuncelle", ktgdeger);

        }

            public ActionResult KategoriGuncelle2(kategori p)
            {
                var ktg = c.kategoris.Find(p.ID);
               
                ktg.kategori_isim = p.kategori_isim;
                //ktg.ID = p.ID;


                c.SaveChanges();
                return RedirectToAction("Index");

            }

        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}