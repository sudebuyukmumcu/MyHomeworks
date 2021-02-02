using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {

            new Manager(),
            new Worker(),
            new Robot()

            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            {

            }
        }

    }
    //birden fazla iterface açarak kategorize etmemiz kolay olabilir
    //burada bir classın birden fazla interface i implemente edebildiğidir.

    
    
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
    void GetSalary();
    }



    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager yemek saati: 12.30");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager maaşı: 7.000TL");
        }

        public void Work()
        {
            Console.WriteLine("Manager mesai saati toplam: 8 saat");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker için Yemek Saati: 12.00");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker'ların aldığı maaş: 3.000TL");
        }

        public void Work()
        {
            Console.WriteLine("Worker'lar mesai saati toplamı: 8");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robotlar ihtiyaca göre çalışırlar");
        }
    }
}

//ÇOKLU IMPLEMENTASYON YAPTIK
//SOLID YAZILIM GELİŞTİRME PRENSİPLERİ, Interface Segregation