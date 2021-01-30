using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //public string FİrstName; //bu yaptığımız şey bir field tanımlamaktır.
        //public string FirstName { get; set; } nun gibi çalışır. ama bu property tanımlamaktır.
        //eğer biz classın içindeki özellikleri tanımlayacaksak field yerine property olanı kullanırız.

        public int Id { get; set; }
        //bir müşterinin özelliklerini tutmak için oluşturduğumuz şey
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //genelde bu şekilde otoproperty olarak kullanıyoruz.

        //eğer fitname i set ederse get ederken olay değişkenlik gösterebilir.
        //bu durumda get i daha açıklayıcı yazmamız gerekir.yani şu şekilde yazarız:
        //burada bir field tanımlanır;

        //private string _firstName; burada firtName i tutuyorum get yaptığımızda bu firstName dönüyor. set yaptığımızda da buradaki ni set ediyoruz.
        //public string FirstName 
        //{
        //    get {return {return "Mr."+_firstName;} yani değeri verirken veya değeri okurken baka bir özellik katmak istersem
        //field ile bu şekilde yazılabilir. Encoupsulation bu ve çok az kullanırız.
        //    set {_firstName =value; }     
        // }
        //burada 





    }
}
