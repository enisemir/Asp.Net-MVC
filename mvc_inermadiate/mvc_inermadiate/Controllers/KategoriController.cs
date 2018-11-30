using mvc_inermadiate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_inermadiate.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {id=1,KategoriAdi="Telefon" },
                new Kategori() {id=1,KategoriAdi="Tablet" },
                new Kategori() {id=1,KategoriAdi="Laptop" }
            };

            return PartialView("KategoriMenu", kategoriler);
        }
    }
}