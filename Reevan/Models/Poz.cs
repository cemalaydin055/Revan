using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reevan.Models
{
    public class Poz
    {
        public int Id { get; set; }

        public string PozAdi { get; set; }

        public string Baslik { get; set; }

        public string Konu { get; set; }

        public int YorumSayisi { get; set; }

        public int GörüntülemeSayisi { get; set; }

        public string Aciklama { get; set; }

        public string Resim { get; set; }

        public bool Durum { get; set; }

    }
}