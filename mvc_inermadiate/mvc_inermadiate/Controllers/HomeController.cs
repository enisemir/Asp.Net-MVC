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
            model.UrunSayisi = Veritabani.Liste.Where(i=> i.Satistami == true).Count();
            model.Urunler = Veritabani.Liste.Where(i=> i.Satistami == true).ToList();

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var urun = Veritabani.Liste.Where(i => i.UrunID == id).FirstOrDefault();
            return View(urun);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun entity)
        {
            Veritabani.ElemanEkle(entity);

            return View("UrunListe",Veritabani.Liste);
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