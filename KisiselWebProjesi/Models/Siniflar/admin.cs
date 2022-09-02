using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string KullaniciAdi { get; set; }            
        public string sifre { get; set; }
    }
}