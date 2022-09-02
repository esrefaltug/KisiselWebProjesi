using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        context c = new context();
        [Authorize] 
        public ActionResult Index()
        {
            var deger = c.anaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.anaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.anaSayfas.Find(x.id);
            ag.isim = x.isim;//değişkenden aldığı ismi veritabanındaki isme eşitle
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();//kaydederiz
            return RedirectToAction("Index");
        }
        public ActionResult ikonlistesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonlistesi");
        }
        public ActionResult ikonGetir(int id)
        {
            var ig=c.ikonlars.Find(id);
            return View("ikonGetir",ig);
        }
        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonlistesi");
        }
        public ActionResult ikonSil(int id)
        {
            var sl = c.ikonlars.Find(id);
            c.ikonlars.Remove(sl);                   
            c.SaveChanges();                        
            return RedirectToAction("ikonlistesi"); 
        }
    }
}