using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        context c = new context();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admin ad)
        {
            var bilgiler = c.admins.FirstOrDefault(x => x.KullaniciAdi == ad.KullaniciAdi && x.sifre == ad.sifre);//girilen kullanıcı adı ve şifreyi veritabanındakiyle karşılaştırdık
            if (bilgiler!=null)//null değilse
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);//sağlanan kullanıcı adı için kimlik doğrulama bileti oluşturur.  
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");//admin panele gönder
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
        
    }
}