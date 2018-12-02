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
            //List<Kategori> Kategoriler = uruncontext.Kategoriler.ToList();
            //var Kategoriler = uruncontext.Kategoriler.ToList();

            //foreach (var kategori in Kategoriler)
            //{
            //    Console.WriteLine("kategori id : {0} kategori adı : {1}", kategori.Id, kategori.KategoriAdi);
            //}

            //var urunler = uruncontext.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun id : {0} urun adı : {1}", urun.Id,urun.UrunAdi);
            //}


            //var urun = uruncontext.Urunler.Find(5);

            //Console.WriteLine("urun id : {0} urun adı : {1}", urun.Id, urun.UrunAdi);


            //var urunler = uruncontext.Urunler.ToList();
            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urun fiyat : {0}", item.Fiyat);
            //}
            //Console.WriteLine("-------------------");
            //foreach (var urun in urunler)
            //{
            //    urun.Fiyat *= 0.25;
            //}
            //uruncontext.SaveChanges();
            //urunler = uruncontext.Urunler.ToList();
            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urun fiyat : {0}", item.Fiyat);
            //}

           
            var urun = uruncontext.Urunler.Find(1);
            if (urun != null)
            {
                uruncontext.Urunler.Remove(urun);
            }
            uruncontext.SaveChanges();
            foreach (var item in uruncontext.Urunler)
            {
                Console.WriteLine("urun id : {0} urun adı : {1}", urun.Id,urun.UrunAdi);
            }
            Console.ReadLine();
        }
    }
}
