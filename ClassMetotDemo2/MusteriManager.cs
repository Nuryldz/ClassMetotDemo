using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler,kaydınız oluşmuştur:" + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kaydınız silinmiştir!" + musteri.Adi);
        }
    }
}