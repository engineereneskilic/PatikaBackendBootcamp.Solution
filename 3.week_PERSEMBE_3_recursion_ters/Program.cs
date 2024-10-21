using System;

namespace _3.week_PERSEMBE_3_recursion_ters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string gonullu = "berkan";

            string Tersi(string metin)
            {
                if(string.IsNullOrEmpty(metin)  || metin.Length == 1)
                {
                    return metin;
                }

                return Tersi(metin.Substring(1) + metin[0]);
            }

            string gonullu = "berkan";
            string tersi = Tersi(gonullu);
            Console.WriteLine("");

        }
    }
}
