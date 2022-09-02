using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        context c = new context();
        public ActionResult Index()
        {
            var deger = c.anaSayfas.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger);
        }
    }
}