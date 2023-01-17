using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reevan.Models
{
    public class PozContext : DbContext
    {
        public PozContext() : base("connection")
        {

        }
        public DbSet<Poz> Pozlar { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<HizmetCesit> HizmetCesitler { get; set; }

        public DbSet<Form> Formlar { get; set; }

        public DbSet<AnaPoz> AnaPozlar { get; set; }
        
    }
}