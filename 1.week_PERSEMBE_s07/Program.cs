using System;

namespace _1.week_PERSEMBE_s07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            Console.WriteLine("Notunuz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            string sonuc;
            if( not < 0 || not > 100 )
            {
                goto baslangic;
            }

            if (not > 80)
            {
                sonuc = "Başarılı";
            } else  if(not > 60)
            {
                sonuc = "Orta";
            }
            else
            {
                sonuc = "Başarısız";
            }

            Console.WriteLine("Sonuç: " + sonuc);

        }
    }
}
