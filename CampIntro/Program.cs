using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "MFÇ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.EgitmenAdi = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.EgitmenAdi = "Ahmet";
            kurs3.IzlenmeOrani = 85;

            Kurs[] kurslar=new Kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi,item.EgitmenAdi,item.IzlenmeOrani);
            }
            
        }
        class Kurs
        {
            public int IzlenmeOrani { get; set; }
            public string EgitmenAdi { get; set; }
            public string KursAdi { get; set; }
        }
    }
}
