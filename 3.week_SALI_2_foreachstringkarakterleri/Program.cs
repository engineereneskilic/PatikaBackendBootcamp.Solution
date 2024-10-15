using System;

namespace _3.week_SALI_2_foreachstringkarakterleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Tersi(string metin)
            {
                string sonuc = "";

                foreach (char c in metin)
                {
                    sonuc = c + sonuc;
                }

                return sonuc;
            }
        }
    }
}
