using birthday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace birthday.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DavetiyeFormu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult Katilanlar()
        {
            var katilanlari = Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
            return PartialView(katilanlari);
        }
    }
}