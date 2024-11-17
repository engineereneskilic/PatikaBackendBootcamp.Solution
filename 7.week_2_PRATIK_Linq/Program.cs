using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_2_PRATIK_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Liste Oluşturma
            // Rastgele - 50 ile 50 arasında değerler üreten 10 elemanlı bir liste oluşturulur.
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(-50, 51));
            }

            //2. Çift Sayılar
            //  Listenin çift sayılarını filtrelemek için `Where` metodu kullanılır.

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // 3. Tek Sayılar
            //    Listenin tek sayılarını filtrelemek için `Where` metodu kullanılır.

            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            //4. Negatif Sayılar
            //Listenin negatif sayılarını filtrelemek için `Where` metodu kullanılır.

            var negativeNumbers = numbers.Where(n => n < 0).ToList();

            //5. Pozitif Sayılar
            //   Listenin pozitif sayılarını filtrelemek için `Where` metodu kullanılır.

            var positiveNumbers = numbers.Where(n => n > 0).ToList();
            //6. Belirli Bir Aralıkta Sayılar
            //15'ten büyük ve 22'den küçük sayıların filtrelenmesi için `Where` metodu kullanılır.

            var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();

            //7. Sayıların Kareleri
            //   Listenin her bir elemanının karesi hesaplanır.

            var squaredNumbers = numbers.Select(n => n * n).ToList();

        }
    }
}
