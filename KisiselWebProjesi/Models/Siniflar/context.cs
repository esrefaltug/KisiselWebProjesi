using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class context:DbContext
    {
        public DbSet<admin> admins { get; set; }
        public DbSet<AnaSayfa> anaSayfas { get; set; }
        public DbSet<ikonlar> ikonlars { get; set; }                                                                                        

    }
}