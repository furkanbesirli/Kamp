using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı
        public void Ekle(Product urun)
        {

            Console.WriteLine("Sepete Eklendi: " + urun.Adi);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("tevrikler: " + urunAdi);
        }


    }
}
