using esyasatis.Concrt;
using esyasatis.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace esyasatis.Controllers
{
    public class UrunController : Controller
    {
        // GET: AdminKategori
       // KategoriRepository kategoriRepository = new KategoriRepository();
        Context c = new Context();
        public ActionResult Index(int sayfa=1)
        {

            //if (file !=null)
            //{
            //    string ResimAdi = System.IO.Path.GetDirectoryName(file.FileName);
            //    string adres = Server.MapPath("/Content/Image" + ResimAdi);
            //    file.SaveAs(adres);

            //    resim.resim = Request.Form["resim"];

            //}



            var degerler = c.Uruns.ToList().ToPagedList(sayfa, 3);
            return View(degerler);

            //var Urun = c.Uruns.ToList();
            //return View(Urun);
        }
        public ActionResult Create()
        {




            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Urun p)
        {

            


            c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
       
        public ActionResult urunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            c.Uruns.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult urunGuncelle(int id)
        {
            List<SelectListItem> deger1 = (from x in c.kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategori_isim,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var ktgdeger = c.Uruns.Find(id);
            return View("urunGuncelle", ktgdeger);

        }

            public ActionResult urunGuncelle2(Urun p)
            {
            

            var ktg = c.Uruns.Find(p.ID);
               
            ktg.Aciklama = p.Aciklama;
            ktg.UrunAd = p.UrunAd;
            ktg.Fiyat = p.Fiyat;
            ktg.Stok = p.Stok;
            ktg.yeniurun = p.yeniurun;
            ktg.Onay = p.Onay;
            ktg.resim = p.resim;
            ktg.adet = p.adet;


            //ktg.ID = p.ID;


            c.SaveChanges();
                return RedirectToAction("Index");

            }


        [HttpPost]
        public ActionResult ImageUpload(HttpPostedFileBase uploadfile)
        {
            if (uploadfile.ContentLength > 0)
            {
                string filePath = Path.Combine(Server.MapPath("~/Content/Image"), Guid.NewGuid().ToString() + "_" + Path.GetFileName(uploadfile.FileName));
                uploadfile.SaveAs(filePath);
            }

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