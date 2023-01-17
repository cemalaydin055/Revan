using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reevan.Models;

namespace Reevan.Controllers
{
    public class KategoriController : Controller
    {
        PozContext db = new PozContext();
        // GET: KategoriMenu
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult KategoriMenu()
        {

            var Kategoriler = db.Kategoriler.ToList();
            var Pozlar = db.Pozlar.ToList();
            ViewBag.UrunSayisi = Pozlar.Count();
            db.SaveChanges();

            return PartialView("KategoriMenu", db);
        }
    }
}