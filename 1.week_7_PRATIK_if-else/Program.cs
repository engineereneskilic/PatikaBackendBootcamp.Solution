﻿using System;

namespace _1.week_7_PRATIK_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya bir sayı girmesi için mesaj gösterilir
            Console.Write("Lütfen bir sayı değeri giriniz: ");

            // Kullanıcının konsola girdiği değer string formatında alınır
            // Convert.ToInt32() fonksiyonu ile bu değer tam sayı (int) formatına çevrilir
            // Elde edilen değer 'sayi' isimli değişkene atanır
            int sayi = Convert.ToInt32(Console.ReadLine());

            // 'sayi' değişkeninin 10'a eşit olup olmadığı kontrol edilir
            if (sayi == 10)
            {
                // Eğer 'sayi' 10 ise, bu mesaj konsola yazdırılır
                Console.WriteLine("Sayi 10'a eşittir.");
            }
            // Eğer 'sayi' 10'dan küçükse bu blok çalışır
            else if (sayi < 10)
            {
                // 'sayi' 10'dan küçükse bu mesaj konsola yazdırılır
                Console.WriteLine("Sayı 10'dan küçüktür");
            }
            else
            {
                // Eğer yukarıdaki koşullar sağlanmadıysa, yani 'sayi' 10'dan büyükse
                // bu blok çalışır ve mesaj konsola yazdırılır
                Console.WriteLine("Sayı 10'dan büyüktür");
            }

            // 2.kontrol yapısı
            // girilen sayının 2 ile bölümünden kalan(mod alma) sıfıra eşitse bu durumda sayı tam bölünüyor demektir. Bu durumda sayımız çifttir
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            } else  // girilen sayının 2 ile bölümünden kalan sıfırdan farklı bir sayıysa 2'ye tam olarak bölünemediği için çift değil tek sayı diyebiliriz
            {
                Console.WriteLine("Girilen sayı tektir.");
            }

        }
    }
}
