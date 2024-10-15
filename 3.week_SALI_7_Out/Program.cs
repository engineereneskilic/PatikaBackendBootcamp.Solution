
using System;

namespace _3.week_SALI_7_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DortIslem(double a, double b, out double toplam, out double fark, out double carpim, out double bölum)
            {
                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                bölum = a / b;

            }

            double top, far, car, bol;

            Console.WriteLine("a = ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b = ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            DortIslem(s1, s2, out top, out far, out car, out bol);

            Console.WriteLine("Toplam: " + top);
            Console.WriteLine("Fark: " + far);
            Console.WriteLine("Çarp: " + car);
            Console.WriteLine("Bol: " + bol);

            Console.ReadKey();
        }
    }
}
