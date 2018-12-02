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
            Kategori k = new Kategori();
            k.Id = 4;
            k.KategoriAdi = "bigisayar";

            Context db = new Context();
            db.Kategoriler.Add(k);
            db.SaveChanges();

            Console.WriteLine("veri kayıt edildi");
            Console.ReadLine();



            //List<Kategori> Kategoriler = new List<Kategori>
            //{
            //    new Kategori(){Id=1, KategoriAdi= "telefon"},
            //    new Kategori(){Id=1, KategoriAdi= "bilgisyar"},
            //    new Kategori(){Id=1, KategoriAdi= "tablet"}
            //};

            //Kategoriler.Add(k);
        }
    }
}
