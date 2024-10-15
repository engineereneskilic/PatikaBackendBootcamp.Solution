
using System;

namespace _3.week_SALI_6_OptionalArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void SaatiYazdir( bool saniyeGizle=false)
            {
                if(saniyeGizle)
                {
                    Console.WriteLine(DateTime.Now.ToShortTimeString());
                    return;
                }

                Console.WriteLine(DateTime.Now.ToLongTimeString());
            }

            SaatiYazdir();
            SaatiYazdir(true);

            Console.ReadKey();

            /// ** return keyword'ü void metotlarda derhal çıkış sağlar.
            // ve sonrasında metoda dair hiçbir kod çalışmaz
            
        }
    }
}
