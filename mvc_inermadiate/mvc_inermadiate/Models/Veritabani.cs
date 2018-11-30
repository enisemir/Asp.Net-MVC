using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_inermadiate.Models
{
    public static class Veritabani
    {
        public static List<Urun> _liste;
        //Veritabani.Liste Şeklinde Çağırılır
        static Veritabani()
        {
            _liste = new List<Urun>()
            {
                new Urun() {UrunID=1, UrunAdi="samsungs6", Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle ", Fiyat=1000, Satistami=true, Resim = "1.jpg" },
                new Urun() {UrunID=2, UrunAdi="samsungs7", Aciklama="idareeder", Fiyat=1000, Satistami=false, Resim = "2.jpg" },
                new Urun() {UrunID=3, UrunAdi="samsungs8", Aciklama="idareeder", Fiyat=2000, Satistami=true, Resim = "3.jpg" },
                new Urun() {UrunID=4, UrunAdi="iphone 6", Aciklama="idareeder", Fiyat=3000, Satistami=false, Resim = "4.jpg"},
                new Urun() {UrunID=5, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=true, Resim = "1.jpg" },
                new Urun() {UrunID=6, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=false, Resim = "2.jpg" },
                new Urun() {UrunID=7, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=true, Resim = "3.jpg" },
                new Urun() {UrunID=8, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=false, Resim = "4.jpg" },
                new Urun() {UrunID=8, UrunAdi="iphone 7s", Aciklama="idareeder", Fiyat=3000, Satistami=false, Resim = "1.jpg" }
            }; 
        }
        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle (Urun entity)
        {
            _liste.Add(entity);
        }
        //Veritaban,.UrunDetay(5)
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if (urun.UrunID == urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}