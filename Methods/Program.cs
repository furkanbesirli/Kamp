using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "seksi karpuz";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");


            }

            Console.WriteLine("------METODLAR-----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);


            sepetManager.Ekle2("ARMUT", "göt gibi", 15, 10);
            sepetManager.Ekle2("çülük", " meme gibi", 15, 10);
            sepetManager.Ekle2("erik", "kütür kütürl", 5, 10);
        }
    }
}
