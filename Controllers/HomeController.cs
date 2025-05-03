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
    public class HomeController : Controller
    {
        // GET: Home
        Context c = new Context();
        public ActionResult Index(int sayfa=1)
        {
            var degerler = c.Uruns.ToList().ToPagedList(sayfa, 3);
            return View(degerler);
        }
    }
}