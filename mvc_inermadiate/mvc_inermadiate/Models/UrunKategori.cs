using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_inermadiate.Models
{
    public class UrunKategori
    {
        public int UrunSayisi { get; set; }
        public List<Urun> Urunler { get; set; }    
    }
}