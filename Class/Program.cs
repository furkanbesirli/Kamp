using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {


            string adi = "SENOS";
            int yas = 12;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "SENOS";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "SENOSKO";
            kurs2.IzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "SENOSKİİİ";
            kurs3.IzlenmeOrani = 31;



            Console.WriteLine("Hello World");
        }

            class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        }
    }
    }
}
