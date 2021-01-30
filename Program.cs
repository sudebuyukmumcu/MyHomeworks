using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //bu şekilde yazarak class ı kullanmak için onun bir örneğini oluşturmak gerekir
            customerManager.Add();
            customerManager.Update();

            ProductManager1 productManager = new ProductManager1();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";
            //Bir class ın property sini eşitlediğiniz zaman yani( firstname=engin ) gibi
            //Bu property deki set blogu çaşılır. o yüzden set blogudur bu.
   

            Customer customer2 = new Customer
            {
                Id = 2,City = "İstanbul",FirstName = "Derin",LastName="Demirog"
            };

            Console.WriteLine(customer2.FirstName); //burada çalışan ise get blogudur. yani bunu getir.
            
            Console.ReadLine();
        }

    }
   
       
}
    

