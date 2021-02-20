using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string kurs1 = "Yazilim Gelistirici Kampi";
           string kurs2 = "Temel Kurs";
           string kurs3 = "Java";*/

            //array-dizi de tut tek tek yazma daa

            string[] kurslar = new string[]{"Yazilim Gelistirici Kampi",
                "Temel Kurs", "Java", "PYTHON"};

            //i+=2 2 2 arttırır
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BITTI");
            //foreach dizilerin elemanlarını tek tek dolaşır her dönüşte
            //her elemana verdiğin ismi (bende kurs) onu kullanır
            //dizileri kolay kolay dolaşmak için kullanılır for yerine

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
        }
    }
}
