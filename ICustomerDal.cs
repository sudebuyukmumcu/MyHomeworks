using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    interface ICustomerDal //Interface1>>ADD>>CLASS>>INTERFACE>>ICustemoreDal

    {
        void Add();
        void Update();
        void Delete();
    }

    //hangi veri tabanından veri çekersek ICustomerDal'ı implemente etmem lazım
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
            class MySqlCustomerDal : ICustomerDal
            {
                public void Add()
                {
                    Console.WriteLine("MySql added");
                }

                public void Delete()
                {
                    Console.WriteLine("MySql deleted");
                }

                public void Update()
                {
                    Console.WriteLine("MySql updated");
                }
            }
        }


    