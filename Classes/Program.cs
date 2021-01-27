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

            Console.ReadLine();
        }

    }
   
       
        }
    

