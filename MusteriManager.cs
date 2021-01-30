using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri./n" + musteri.Id + "/n " + musteri.Adi + "/n" + musteri.Soyadi + "/n" + musteri.Yasi + "/n" + musteri.MusteriNo + "/n");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri" + musteri.Id + "/n " + musteri.Adi + "/n" + musteri.Soyadi + "/n" + musteri.Yasi + "/n" + musteri.MusteriNo + "/n");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Listelenen Müşteri" + musteri.Id + "/n " + musteri.Adi + "/n" + musteri.Soyadi + "/n" + musteri.Yasi + "/n" + musteri.MusteriNo + "/n");
        }


    }
}