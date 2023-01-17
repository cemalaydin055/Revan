using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Reevan.Models
{
    public class HizmetCesit
    {
        public int Id { get; set; }

        public string Resim { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string AltBaslik1 { get; set; }
        public string AltBaslik2 { get; set; }
        public string AltBaslik3 { get; set; }
    }
}