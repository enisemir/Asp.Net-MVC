using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_inermadiate.Models;

namespace mvc_inermadiate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {      

            UrunKategori model = new UrunKategori();
            model.UrunSayisi = Veritabani.Liste.Count();
            model.Urunler = Veritabani.Liste;

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;
            return View(model);
        }

        public ActionResult Contact()
        {
            return View();  
        }
        public ActionResult About()
        {
            return View();
        }
    }
}