using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Çilek gibi Çilek";

            string urunAdi3 = "Karpuz";
            double fiyati3 = 80;
            string aciklama3 = "Diyarbakır Karpuzu";


            string[] meyveler = new string[] { "Elma", "Çilek", "Karpuz", };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Çilek Gibi Çilek";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2,urun3 };

            //type-safe -- tip güvenliği
            foreach  (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
            }


            Console.WriteLine("-------------------METOTLAR----------------------");

            //instance -- class örneği
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Çilek", "Çilek gibi Çilek", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);



        }
    }
}

// Do not repeat yourself - Kendini Tekrar Etme - Dry - Clean Code - Best Practice 