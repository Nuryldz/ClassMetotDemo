using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Simay";
            musteri1.Soyadi = "Koç";
            musteri1.Yas = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Pelin";
            musteri2.Soyadi = "Yiğit";
            musteri2.Yas = 45;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Melih";
            musteri3.Soyadi = "Bulut";
            musteri3.Yas = 26;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            //Müşteri Listeleme
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yas);
            }




            //Müşteri Ekleme
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            //Müşteri Silme
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
