using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = "1234567890";
            musteri1.Adi = "Sude";
            musteri1.Soyadi = "Büyükmumcu";
            musteri1.Yasi = 23;
            musteri1.MusteriNo = "12345";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "345678912";
            musteri2.Adi = "Duygu";
            musteri2.Soyadi = "Dinler";
            musteri2.Yasi = 22;
            musteri2.MusteriNo = "34567";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "78901234";
            musteri3.Adi = "Tuba";
            musteri3.Soyadi = "Ebeperi";
            musteri3.Yasi = 23;
            musteri3.MusteriNo = "65789";

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3};

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.List(musteri1);
            }
            musteriManager.Delete(musteri2);

        }
    }
}
