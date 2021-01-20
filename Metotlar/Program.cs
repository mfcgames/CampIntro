using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 500;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 220;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(">ÜRÜN "+urun.Adi);
                Console.WriteLine(">FİYAT "+urun.Fiyati);
                Console.WriteLine(">AÇIKLAMA "+urun.Aciklama);
                Console.WriteLine("------------********************-----------");
            }

            Console.WriteLine("---------------Metotlar--------------");
            //instance-örnek
            //encapsulation --KAPSÜLLEME

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("elma", "yeşil elma", 12,10);

        }
    }
}
