
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reevan.Models;

namespace Reevan.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        PozContext db = new PozContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay(int id)
        {

            var liste = db.Pozlar.ToList() ;



            var poz = liste.Where(i => i.Id == id).FirstOrDefault();


            return View(poz);
        }
    }
}