using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //LİNQ (Language integrated query)
            Context uruncontext = new Context();
            List<Urun> urunler = new List<Urun>()
            {
                new Urun() { UrunAdi = "samsung s4", Fiyat = 2000, StokAdeti = 100, Satistami = true },
                new Urun() { UrunAdi = "samsung s5", Fiyat = 3000, StokAdeti = 100, Satistami = true },
                new Urun() { UrunAdi = "samsung s6", Fiyat = 4000, StokAdeti = 100, Satistami = true },
                new Urun() { UrunAdi = "samsung s7", Fiyat = 5000, StokAdeti = 100, Satistami = true },
                new Urun() { UrunAdi = "samsung s8", Fiyat = 6000, StokAdeti = 100, Satistami = true },               
            };

            foreach (var urun in urunler)
            {
                uruncontext.Urunler.Add(urun);
            }
            uruncontext.SaveChanges();
            Console.WriteLine("veritabanı oluştu");
            Console.ReadLine();
        }
    }
}
