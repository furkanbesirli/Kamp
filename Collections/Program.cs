using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Senoş", "Furkan", "Bade", "Aytuğ"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            /*bu şekilde olduğu zaman isimelr veri tabanından geldiği için 
            diziler kullanırsak sonradan biz isim ekleyemeyiz eklerseks patlar
            onun için koleksionları kullanıcaz
            4 elemanlı oluşturup sonra 5. yi ekleyemezsin eklersen diğerleri kaybolur*/

            List<string> isimler2 = new List<string> { "Senoş", "Furkan", "Bade", "Aytuğ" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Yeni bebi");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
