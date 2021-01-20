using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Aydın";
            musteri1.Tckn = 85987654321;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Buse";
            musteri2.Soyadi = "Yılmaz";
            musteri2.Tckn = 12345678958;

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Tckn);
                musteriManager.Listele(musteri);
                Console.WriteLine("---------------------------");

            }
        }
    }
}
