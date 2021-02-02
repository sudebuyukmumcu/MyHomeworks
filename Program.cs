using Interfaces;
using Interfaces1;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //InterfaceIntro();
            //Demo();

            //Şimdi senoryomuz; bizim bir verimiz var ve bu veriyi hem şirketin oracle veritabanına hem de sql veritabanına yazmayı planlıyoruz
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
            //burada amaç uygulamanın bağımlılıklarını minimize etmek.
        }

        private static SqlServerCustomerDal OracleCustomerDal()
        {
            throw new NotImplementedException();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal()); //Burada soruyor oracle a mı ekleyim sql mi. bizde oracle i seçtik örnek olarak.
                                                          // IPerson person = new Customer(); böyle yazılabilir
                                                          //bir interface in insteance ı oluşturulamaz.Soyut nesneleri new leyemeyiz. Yani
                                                          //IPerson person=new IPerson denilmez.bunun yerine classlardaki somut nesnelerimiz tanımlanır.
        }


        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Sude",
                LastName = "Büyükmumcu",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Hüma",
                LastName = "Büyükmumcu",
                Departmant = "Computer Sciences"
            };

            manager.Add(customer);
            manager.Add(student);
        }
    }
    interface IPerson //başında büyük harf I olması Interface demek.
                      //buna ise soyut nesne denir.Soyut nesneler tek başşına bir anlam ifade etmezler.
    {
        int Id { get; set; } //public yazılmaz. 
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson //somut nesne, buradaki class da tanımladığımız neslere IPerson diyerek ne olduklarını tanımlıyoruz.
                             //bu şu anlama geliyor. Biz IPersonda tanımlanmış her şeyi bu classlarda görebiliriz artık.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } //örneğin sadece müşteriye özel bir şey tanımlamak istiyorsak bu şekilde ekleme yapaniliriz.
    }
    class Student : IPerson //somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } //aynı şekilde öğrencide ise sadece departmanı tutmak istiyoruz.
    }

    //müşteriye ait ve öğrenciye ait ayrıca özellikler tanımlayabildik. Aynı zamanda hepsi için ortak olanı da implemente ettik.
}
class PersonManager
{
    //public void Add(Customer customer) 
    //burada metot tanımlamak istiyorum. Burayı böyle yazmak yerine hepsini tanıması için IPErson şeklinde tanımlarız.
    //burada bana müşteri tipinde bir parametre ver diyorum.
    public void Add(IPerson person) //ben buraya IPerson dediğim zaman ister customer gönderirim ister student
        //çünkü IPerson interface ve classlara tanımladık.
    {
        Console.WriteLine(person.FirstName);
    }
}

