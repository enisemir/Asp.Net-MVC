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


            var urun = uruncontext.Urunler.Find(5);

            Console.WriteLine("urun id : {0} urun adı : {1}", urun.Id, urun.UrunAdi);
            Console.ReadLine();
        }
    }
}
