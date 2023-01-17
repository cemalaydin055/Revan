using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reevan.Models;

namespace Reevan.Controllers
{

    public class HomeController : Controller
    {
        PozContext db = new PozContext();
        // GET: Home
        public ActionResult Index()
        {
            var AnaPoz = db.AnaPozlar.ToList();
           
            return View(db);
        }

        public ActionResult Hakkimizda()
        {

            var HizmetCesitler = db.HizmetCesitler.ToList();

            return View(db);
        }

        [HttpGet]
        public ActionResult İletisim()
        {
            return View();
        }




        [HttpPost]
        public ActionResult İletisim(string Adi, double Telefon, string Eposta, string Mesaj, bool Durum)
        {

            Form formekle = new Form();
            formekle.Adi = Adi;
            formekle.Telefon = Telefon;
            formekle.Eposta = Eposta;
            formekle.Mesaj = Mesaj;
            formekle.Durum = Durum;

            if (Durum == true)
            {
                db.Formlar.Add(formekle);
                db.SaveChanges();
                ModelState.Clear();

            }


            else
            {
                ModelState.Clear();
            }



            return View();
        }

        public ActionResult Liste()
        {
            return View();
        }

        public ActionResult Pozlar()
        {
            var Pozlar = db.Pozlar.ToList();
            var Kategoriler = db.Kategoriler.ToList();
            ViewBag.UrunSayisi = Pozlar.Count();
            ViewBag.Pozlar = Pozlar;

            return View(db);

        }

        public ActionResult Detay(int id)
        {
            var liste = db.AnaPozlar.ToList();

            var anapoz = liste.Where(i => i.Id == id).FirstOrDefault();


            return View(anapoz);
        }

    }
}