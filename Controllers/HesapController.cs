using System;
using System.Collections.Generic;
using System.Linq;
using esyasatis.Entities;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace esyasatis.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici p)
        {
            var bilgiler = c.kullanicis.FirstOrDefault(x => x.Email == p.Email && x.sifre == p.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                Session["sifre"] = bilgiler.sifre.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Hesap");
            }
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAd == p.KullaniciAd && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAd, false);
                Session["KullaniciAd"] = bilgiler.KullaniciAd.ToString();
                return RedirectToAction("Index", "AdminKategori");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Hesap");
            }
        }
    }
}