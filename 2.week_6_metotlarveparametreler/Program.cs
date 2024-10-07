using System;
using System.Runtime;
using System.Threading.Channels;

namespace _2.week_6_metotlarveparametreler
{
    internal class Program
    {
     
        double OrtalamaHesapla(int[] notlar)
        {
            int toplam = 0; 

            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }

            double ortalama = (double)(toplam) / (double)notlar.Length;

            return ortalama;

        }

      
    }
   

   
}
