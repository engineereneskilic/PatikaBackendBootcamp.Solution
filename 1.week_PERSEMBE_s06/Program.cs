using System;

namespace _1.week_PERSEMBE_s06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = Convert.ToInt32(Console.ReadLine());

            if(no < 1 || no > 7)
            {
                Console.WriteLine("Geçersiz gün!");
                Console.WriteLine("Çıkmak için bir tuşa basınız..");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Buraya giremez");

            Console.ReadKey();

        }
    }
}
