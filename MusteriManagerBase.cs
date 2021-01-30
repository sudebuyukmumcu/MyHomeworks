namespace ClassMetotDemo
{
    internal class MusteriManagerBase
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşterinin ID'si : " + musteri.Id);
            Console.WriteLine("Eklenen Müşterinin Adi: " + musteri.Adi);
            Console.WriteLine("Eklenen Müşterinin Soyadi:" + musteri.Soyadi);
            Console.WriteLine("Eklenen Müşterinin Yaşı:" + musteri.Yasi);
            Console.WriteLine("Eklenen Müşterinin Müşteri No'su:" + musteri.MusteriNo);
        }
        public void Delete(Musteri musteri)
    }
}