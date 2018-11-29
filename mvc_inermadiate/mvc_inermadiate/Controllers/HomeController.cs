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
            List<Urun> urunler = new List<Urun>()
            {
                new Urun() {UrunID=1, UrunAdi="samsungs6", Aciklama="idareeder", Fiyat=1000, Satistami=true },
                new Urun() {UrunID=2, UrunAdi="samsungs7", Aciklama="idareeder", Fiyat=1000, Satistami=false },
                new Urun() {UrunID=3, UrunAdi="samsungs8", Aciklama="idareeder", Fiyat=2000, Satistami=true },
                new Urun() {UrunID=4, UrunAdi="iphone 6", Aciklama="idareeder", Fiyat=3000, Satistami=false },
                new Urun() {UrunID=5, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=true },
                new Urun() {UrunID=6, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=false },
                new Urun() {UrunID=7, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=true },
                new Urun() {UrunID=8, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=false }
            };
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {id=1,KategoriAdi="Telefon" },
                new Kategori() {id=1,KategoriAdi="Tablet" },
                new Kategori() {id=1,KategoriAdi="Laptop" }
            };

            UrunKategori model = new UrunKategori();
            model.UrunSayisi = urunler.Count();
            model.Urunler = urunler;
            model.Kategoriler = kategoriler;

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;
            return View(model);
        }
    }
}