using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reevan.Models
{
    public class PozKategoriModel
    {
        public List<Poz> Pozlar { get; set; }
        public List<Kategori> Kategoriler { get; set; }


        public int UrunSayisi { get; set; }
    }
}