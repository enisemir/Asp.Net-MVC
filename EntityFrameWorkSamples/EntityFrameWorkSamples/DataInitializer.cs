using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSamples
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori()
                {
                 KategoriAdi="telefon"
                }
            };



            List<Urun> urunler = new List<Urun>()
            {
                new Urun() {UrunAdi="samsung s5", Fiyat=1000, StokAdeti=100 },
                 new Urun() {UrunAdi="samsung s6", Fiyat=2000, StokAdeti=100 },
                  new Urun() {UrunAdi="samsung s7", Fiyat=3000, StokAdeti=100 },
                  new Urun() {UrunAdi="samsung s8", Fiyat=4000, StokAdeti=20 },
                  new Urun() {UrunAdi="samsung s9", Fiyat=5000, StokAdeti=100 },
                   new Urun() {UrunAdi="samsung s10", Fiyat=6000, StokAdeti=0 },
                    new Urun() {UrunAdi="samsung s11", Fiyat=7000, StokAdeti=100 },
                     new Urun() {UrunAdi="samsung s12", Fiyat=8000, StokAdeti=200 },
            };

            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
