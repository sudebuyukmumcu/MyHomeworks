using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            //mecburen string vermemiz lazım çünkü yukarıdaki list<string> dedim

        }
    }
    class MyList <T> //Generic Class 
        //buaraya T dedik farketmez biz Type dan T dedik.
        //bu claassın çalışma tipi T dedik
    //Mylist generic olmayan tiptir.Genericlerle hangi tipi verirseniz içindeki operasyonlar o tipte çalışıyor.
    {
        T[] _array;
        T[] _temparray; //geçici olarak yedek almak için açtığımız array
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray = _array; //bu demek oluyor ki temparray, array in referansını tutuyor.
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }

            //eleman sayısını bir arttırmamız gerekir. Arraylerde eleman sayısını bir arttırınca newlememiz gerekiyordu.
            _array[_array.Length - 1] = item;//bunu yazmadan önce yedek almamız gerekir
            //çünkü arraylerde yeni ekleme (newleme) yaptığımızda öncekiler siliniyordu.
        }
             public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
